# PocketGuide – Augmented Reality Cultural Explorer

PocketGuide is an Android-based Augmented Reality (AR) application built with Unity and Vuforia, designed to bring Nepal’s cultural and historical heritage to life. By scanning temples, monuments, statues, murals, and other landmarks, users can access rich audio-visual stories, historical information, and interactive 2D models right on their mobile screens.  

The app works offline and supports multiple languages, making it accessible to  local visitors,international tourists and students. PocketGuide transforms traditional sightseeing into an immersive learning experience, allowing users to explore heritage sites at their own pace while discovering fascinating stories about Nepal’s history, architecture, and culture.  

With its interactive approach, PocketGuide not only promotes cultural tourism but also helps preserve Nepal’s heritage digitally. Students, travelers, and history enthusiasts can engage with cultural sites in a fun and educational way, making every visit a memorable journey. By combining advanced AR technology with contextual storytelling, the app bridges the gap between tradition and modern digital exploration.


---

## Overview

PocketGuide transforms traditional travel experience into a digital interactive guide.  
Users scan a landmark or image target using their phone camera, and the app displays:

- Audio narration  
- Text information  
- Visual overlays  
- Cultural and historical facts  

All content is stored locally so the application works without internet.

---

## Features

- Marker-based AR using Vuforia  
- Offline content delivery  
- Multilingual support (English & Nepali)  
- Responsive 9:16 vertical UI  
- Scene-based navigation  
- Audio guide system  
- APK distribution via website  
- Optimized size

---

## Technology Stack

- Unity 6  
- Vuforia SDK  
- C# Scripting  
- Android SDK  
- Unity Canvas System
  
## Data & Content Architecture

PocketGuide uses a hybrid local data structure based on DAT and XML files to enable fully offline AR experiences.

### Data Formats Used

#### XML Structure
- Language-based content mapping  
- Place information hierarchy  
- UI text localization  
- Audio file linking  
- Scene metadata  

#### DAT Files
- Vuforia Image Target Database (.dat & .xml pair)  
- Feature extraction data  
- Target tracking configuration  
- AR recognition parameters

---

## Development Cycle

1. Requirement analysis and concept design  
2. UI design in 9:16 vertical format  
3. Unity scene creation  
4. Vuforia integration  
5. C# scripting for navigation  
6. Content creation (audio + text)  
7. Trial testing on devices  
8. Iterative improvements  
9. Final APK build  

---

## Testing Approach

We followed trial test methodology:

- Tested on multiple Android devices  
- Real location testing  
- Image recognition accuracy  
- UI responsiveness  
- Audio clarity  
- User feedback sessions  

---

## Installation

### From GitHub
1. Visit PocketGuide Repo. 
2. Download APK from the GitHub Repo.
3. Enable “Install from Unknown Sources”.  
4. Install and open.


## Achievements

- Completed all planned objectives  
- Working AR recognition  
- Multilingual system  
- Offline guide  
- Website with APK download  
- Responsive UI  
- Cultural digitalization  

## Limitations
- Android only  
- No VPS support 
- Large media size  

## Future Enhancements

- Location-based AR  
- More languages  
- Cloud content update  
- iOS version  
- More heritage sites  

---

## About

PocketGuide was developed as an academic project at:

[Department of Management Informatics and Communication](https://mic.ku.edu.np/),  
[Kathmandu University School of Management](https://kusom.edu.np).

The project was initially conceptualized & developed as *TravelAR* ,as a semester project and  later redesigned, enhanced, and redeveloped as **PocketGuide** with improved architecture, content structure, and user experience by [DigiKrit](https://www.instagram.com/digi_krit/).

