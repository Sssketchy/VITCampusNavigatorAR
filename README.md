# AR Navigation using AR+GPS in Unity

## Overview
This project implements **Augmented Reality (AR) navigation** using **GPS tracking** in Unity. The system helps users navigate a real-world environment by overlaying a virtual path in AR, using the **AR+GPS Location** plugin.

## Features
- **GPS-based path tracking**
- **AR waypoints for navigation**
- **Real-world alignment with Unity 3D models**
- **Mobile-friendly AR navigation**

## Requirements
### Software & Tools
- **Unity 2021+** (LTS recommended)
- **AR Foundation & ARCore/ARKit** (for AR support)
- **AR+GPS Location Plugin** (from Unity Asset Store)
- **Google My Maps / GPS Logger** (to export GPX/KML paths)

### Hardware
- **Android (ARCore-enabled) / iPhone (ARKit-supported)**
- **GPS & Internet connection required**

## Installation Steps
### 1. Setup Unity Project
1. Open Unity and create a **3D (URP optional)** project.
2. Install **AR Foundation, ARCore XR Plugin (Android), ARKit XR Plugin (iOS)** from **Package Manager**.
3. Import the **AR+GPS Location** plugin from the Unity Asset Store.

### 2. Configure AR & GPS
1. Enable **ARCore/ARKit support** in **Project Settings** → XR Plugin Management.
2. Set up GPS permissions:
   - Go to **Edit** → **Project Settings** → **Player** → **Other Settings**.
   - Add **`ACCESS_FINE_LOCATION`** in **Android/iOS Player Settings**.

### 3. Import GPS Path (GPX/KML)
1. Record the real-world path using **Google My Maps** or a **GPS Logger**.
2. Export the path as a **GPX/KML** file.
3. Convert the file to JSON using a script or online converter.

### 4. Implement AR Navigation
1. Attach **`ARLocationProvider`** to a GameObject to access GPS data.
2. Leveraging **AR + GPS package** we are fetching the location and placing it on the plane.
3. Use **`PlaceAtLocation`** component to place objects in AR based on GPS coordinates.
4. Implement **a Line Renderer or 3D path indicators** to show directions.

### 5. Build & Deploy
1. Set the **Build Platform** to **Android or iOS**.
2. Enable **location permissions** in player settings.
3. Download the APK and Enjoy the Experience.

## Usage
1. Launch the app and grant GPS & AR permissions.
2. The AR Data points show the locations of the places on the campus.

## Future Improvements
- Implement **voice-guided navigation**.
- Add **offline Navigation**.

## License
MIT License

Copyright (c) [year] [fullname]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

