#!/bin/bash

resourceGroup=build2018
amsAccountName=build2018

# Create a simple Transform for Adaptive Bitrate Encoding
az ams transform create \
 --name myFirstTransform \
 --preset-names AdaptiveStreaming \
 --description 'a simple Transform for Adaptive Bitrate Encoding' \
 -g $resourceGroup \
 -a $amsAccountName \

 # Create a Transform for Video Analyer Preset
az ams transform create \
 --name videoAnalyzerTransform \
 --preset-names  VideoAnalyzer \
 -g $resourceGroup \
 -a $amsAccountName \

 # Create a Transform for Audio Analzyer Preset
az ams transform create \
 --name audioAnalyzerTransform \
 --preset-names  AudioAnalyzer \
 -g $resourceGroup \
 -a $amsAccountName \

# Create a Transform with two built-in Presets executed in sequence
az ams transform create \
 --name twoPresetTransform \
 --preset-names AdaptiveStreaming VideoAnalyzer \
 -g $resourceGroup \
 -a $amsAccountName \

# List all the Transforms in an account
az ams transform list -a $amsAccountName -g $resourceGroup

echo "press  [ENTER]  to continue."
read continue