# AR Chatbot using Gemini API

## Overview
This project is an **AR-powered chatbot** that leverages the **Gemini API** to provide real-time answers and jokes. The user types a question in AR space, and the bot responds with a text overlay on the AR screen.

## Features
- **AR text input & overlay responses**
- **Integration with Gemini API for AI responses**
- **Humorous replies & jokes**
- **Real-time interaction in AR**

## Requirements
### Software & Tools
- **Unity 2021+** (LTS recommended)
- **AR Foundation & ARCore/ARKit** (for AR support)
- **Google Gemini API Key** (for AI responses)
- **TextMeshPro** (for AR text rendering)

### Hardware
- **Android (ARCore-enabled) / iPhone (ARKit-supported)**
- **Internet connection required for API requests**

## Installation Steps
### 1. Setup Unity Project
1. Open Unity and create a **3D (URP optional)** project.
2. Install **AR Foundation, ARCore XR Plugin (Android), ARKit XR Plugin (iOS)** from **Package Manager**.
3. Import **TextMeshPro** for high-quality text rendering in AR.

### 2. Setup Gemini API
1. Get a **Google Gemini API Key** from [Google AI](https://ai.google.dev/).
2. Store the API key securely in Unity (e.g., **PlayerPrefs** or a server-side environment variable).
3. Create a **Gemini API Manager** script to handle API requests.

### 3. Implement AR Chat System
1. Attach **AR Session & AR Camera** to a scene.
2. Create a **virtual keyboard UI** for text input.
3. Display **TextMeshPro text in AR space** for responses.
4. Send user input to the **Gemini API** and retrieve AI-generated text.
5. Parse and format responses, ensuring some include **jokes**.

### 4. Build & Deploy
1. Set the **Build Platform** to **Android or iOS**.
2. Enable **internet permissions** in player settings.
3. Deploy the AR chatbot app to a mobile device.

## Usage
1. Launch the app and grant AR permissions.
2. Type a question in the AR chat window.
3. Receive an AI-generated response overlayed in AR.
4. Enjoy **random jokes** from the bot!

## Future Improvements
- Add **speech-to-text input** and **text-to-speech output**.
- Implement **voice output for responses**.
- Enable **3D avatars for chatbot interaction**.

## License
MIT License

Copyright (c) 2025 VITCampusNavigatorAR

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

