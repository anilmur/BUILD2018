# Encode with a custom Transform
This sample shows how to create a custom encoding Transform using the StandardEncoderPreset settings. 
It also demonstrates how to submit a job that uses an HTTPs ingest URL (JobInputHttp) instead of having to first create and upload an Asset. 


## .NET Core Sample

This is a Quickstart sample showing how to use Azure Media Services API and .NET SDK in .NET Core. 
Open this folder directly (seperately) in Visual Studio Code. 


## Update the App.config

To use this project, you must first update the App.config with your account settings. The settings for your account can be retrieved using the following Azure CLI command in the Media Services module.

The following bash shell script creates a service principal for the account and returns the app.config settings as xml

    #!/bin/bash

    resourceGroup=build2018
    amsAccountName=build2018
    amsSPName=build2018AADapplication

    # Create a service principal with password and configure its access to an Azure Media Services account.
    az ams account sp create \
    --account-name $amsAccountName \
    --name $amsSPName \
    --resource-group $resourceGroup \
    --role Owner \
    --xml \
    --years 2 \