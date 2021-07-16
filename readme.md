# Boilerplate code for ENSEK Developer interview exercise

## Overview

The included project can be used as a starting point for completing the ENSEK developer interview exercise. This is based off of .Net Core 3.
It contains the required endpoint, accepting a file input. It creates a localdb database already seeded with the accounts provided in the SampleFiles folder. 

Please feel free to create any addtional projects, change any structure or start from scratch as would best suit your programming style and choice. 

## To Run 

dotnet run --project Ensek.Apis

this will launch the server on port 52073

## To Test

Although creating a UI to interact with your API is encouraged the endpoint can be tested also with a simple curl command. 

"Curl/curl" -F "data=@SampleFiles/Meter_Reading.csv" http://localhost:52073/meter-readings-uploads
