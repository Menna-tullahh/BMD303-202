"""
Definition of views.
"""

from datetime import datetime
from django.shortcuts import render
from django.http import HttpRequest, HttpResponse
from .models import FileUpload, patient
from .create_fhir import save_fhir, get_fhir
from multiprocessing import Process
import asyncio
import matplotlib.pyplot as plt

import dicom

from django.core.files.storage import FileSystemStorage
from django.conf import settings

def home(request):
    """Renders the home page."""
    assert isinstance(request, HttpRequest)
    return render(
        request,
        'app/index2.html',
        {
            'title':'Home Page',
            'year':datetime.now().year,
        }
    )


def contact(request):
    """Renders the contact page."""
    record = FileUpload.objects.all()
    patientObject = patient.objects.all()

    if request.method== "POST":
        file = request.FILES["myfile"]
       # nationalID = request.POST["nationalID"]

        patientID = request.POST.get('dropdown', None)
        modality = request.POST.get('dropdown2', None)
        patientInformation = patientObject.get(ID= patientID)
        saveFile = FileUpload(dicomImg=file, patientID = patientInformation, modality = modality)
        saveFile.save()



        img = dicom.read_file("./media/dicom/{}".format(str(file)), force=True)
        imgModality = img.Modality
        # time = img.StudyTime
        # date = img.StudyDate
        # newDate = date[:4]+ '-' + date[4:6] + '-' + date[6:8]
        # date_time_obj = datetime.strptime(newDate, '%Y-%d-%m')
        numberOfSeries = img.SeriesNumber
        numberOfInstances = img.InstanceNumber
        seriesInstanceUID = img[0x0020, 0x000e].value
        seriesDescription = img[0x0008, 0x103e].value
        print(file)

        result = FileUpload.objects.get(dicomImg="dicom/{}".format(str(file)))
        imgID = result.ID

        loop = asyncio.new_event_loop()
        loop.run_until_complete(save_fhir(str(imgModality), patientInformation.nationalID, numberOfSeries, numberOfInstances, seriesInstanceUID, seriesDescription, imgID))



        return render(
            request,
            'app/contact.html',
            {
                'title':'Add Record',
                'year':datetime.now().year,
                'message': True,
                'patientObject': patientObject
            }

        )
    else:
        return render(
            request,
            'app/contact.html',
            {
                'title':'Add Record',
                'year':datetime.now().year,
                'patientObject': patientObject
            }

        )

def about(request):
    """Renders the about page."""

    record = FileUpload.objects.all()
    patientObject = patient.objects.all()
    sp_patient = patient.objects.get(ID=1)
    test_list=[]
    test_list_number=[]
    test_list_national=[]
    for item in record:
        test_list.append(patient.objects.get(ID=item.patientID.ID).fullName)
        test_list_number.append(patient.objects.get(ID=item.patientID.ID).phone)
        test_list_national.append(patient.objects.get(ID=item.patientID.ID).nationalID)


    context= {
        'record': record,
        'patientObject': patientObject,
        "sp_patient":sp_patient,
        "test_list":test_list,
        "test_list_number":test_list_number,
        "test_list_national":test_list_national,
        'title': 'All Record',
        }
    return render(
        request,
        'app/about.html',
        context=context
    )

def sp_contact(request,con_id):
    loop = asyncio.new_event_loop()
    x = loop.run_until_complete(get_fhir(con_id))
    dicomID = x.id

    mod = x.modality[0].get('code')
    nationalID = x.subject.reference[39:53]
    p = patient.objects.get(nationalID=nationalID)
    patientID = p.ID

    numberOfSeries = x.numberOfSeries
    numberOfInstances = x.numberOfInstances
    uid = x.series[0].get('uid')
    dicomURL = FileUpload.objects.get(ID=dicomID)
    image = dicomURL.dicomImg
    img = dicom.read_file('media/{}'.format(str(image)), force=True)
    pName =  img[0x0010, 0x0010].value
    pGender =  img[0x0010, 0x0040].value
   # pAge =  img[0x0010, 0x1010].value
    if request.method == "POST":

        plt.imshow(img.pixel_array, cmap='gray')
        plt.show()


    context = {
        'con_id' : con_id,
        'dicomID' : dicomID,
        'mod': mod,
        'nationalID': nationalID,
        'numberOfSeries' : numberOfSeries,
        'numberOfInstance':numberOfInstances,
        'uid':uid,
        'patientID':patientID,
        'pName': pName,
        'pGender':pGender,
        #'pAge':pAge,
        'title': 'Details',
    }

    return render(
        request,
        'app/dicomDetails.html',
        context=context
    )



