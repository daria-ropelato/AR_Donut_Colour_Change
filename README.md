# 🍩 AR_Donut_Colour_Change
An interactive AR experience built with Unity and AR Foundation, where a 3D donut model appears on image tracking and changes icing color when the screen is tapped. Blender was used for 3D modeling, and the project is optimized for iOS devices.

# 🍩 Purpose of the Project
The goal of this project is to explore interactive augmented reality (AR) experiences using Unity and AR Foundation by creating a playful application where a 3D donut appears on a tracked image marker. The user can tap the screen to change the icing color of the donut dynamically in AR. This project serves both as an introduction to AR development and a foundation for building more complex, interactive AR applications.

# 🍩 What It Does
- Detects a real-world image marker using the phone’s camera.
- Instantiates a 3D donut model aligned with the marker.
- Allows the user to tap anywhere on the screen to change the icing color randomly.
- Runs on iOS (tested on iPhone) using ARKit.

# 🍩 Technologies Used

- **Blender**: For modeling the 3D donut (base, icing, sprinkles).
- **Unity**: Game engine used to build the AR application.
- **AR Foundation**: Unity package for building cross-platform AR experiences.
- **ARKit XR Plugin**: Enables AR on iOS devices using Apple’s ARKit.
- **Xcode**: Apple’s IDE used to build and deploy to iPhones.
- **PNG Marker**: A digital image used as a marker for tracking.
- **C# Scripting**: Used for managing AR image detection and model instantiation.

# 🍩 Possible Upgrades
- Add a color picker UI for manual icing selection.
- Implement touch-based sprinkle placement (physics-based drop-on-tap).
- Support multiple markers for different donut types.
- Add a “donut customizer” with flavors and toppings.
- Port to Android using ARCore (cross-platform compatibility).

# 🎥 Demo (How It Works)
- Launch the app on iPhone.
- Point the camera at the printed or screen-based donut image marker.
- The 3D donut will appear anchored to the image.
- Tap the screen — the icing color of the donut will change randomly.

A quick preview of the AR Donut experience:

https://github.com/user-attachments/assets/14bc7a99-cb4b-4102-a6ab-e2ed31bc7e70
