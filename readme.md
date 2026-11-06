# VR Medical Anatomy Visualizer

A Unity VR prototype developed to demonstrate clinical MRI data visualization. This project bridges raw medical imaging and spatial computing by transforming patient scans into an interactive, high-fidelity virtual reality environment for anatomical inspection.

## Key Features

* **Medical Data Pipeline:** Processed clinical MRI scans into accurate 3D meshes using **3D Slicer**, bringing real-world patient data into interactive **Unity VR** environments.

* **Interactive X-Ray Vision:** Engineered a custom **URP Shader Graph** with a **Fresnel effect** for a translucent hologram, enabling real-time internal tumor inspection.

* **Stable VR Manipulation:** Configured **kinematic physics** via the **XR Interaction Toolkit (XRI)** for stable, drift-free spatial manipulation of anatomical models.

* **Simulator Testing & Inputs:** Built **C#** logic and **OpenXR** input mapping for hardware-direct controller toggles, validating all interactions via the **XR Device Simulator**.

## Technologies Used

* **Game Engine:** Unity 6

* **Language:** C#

* **VR Frameworks:** XR Interaction Toolkit (XRI), OpenXR, XR Device Simulator

* **Graphics:** Universal Render Pipeline (URP), Shader Graph

* **Medical Imaging:** 3D Slicer