# 💡 Sprites 3D Lighting Support

This repository provides a simple setup for enabling Unity Native 3D lighting and shadow casting on Sprite Renderers, making it easier to create hybrid 2D/3D visual styles and atmospheric scenes.

---
## 📦 Included Assets
- `ShaderGraph_Sprite_Shadow`  
  Shader Graph used to render shadows on Sprite Renderers while maintaining compatibility with 3D scene lighting.

- `Mat_Sprite_Shadow`  
  Material configured to use the shadow-compatible shader.

- `SpriteShadowCaster`  
  Utility script that enables shadow casting bool value on Sprite Renderer.

---
## ⚙️ Requirements

- Unity 2021+ recommended  
- Universal Render Pipeline (URP) recommended  
- Shader Graph package installed  

---
# 📥 Installation

1. Clone or download this repository  
2. Import the files into your Unity project  
3. Assign `Mat_Sprite_Shadow` to your Sprite Renderer  
4. Add `SpriteShadowCaster` to the desired GameObject  
5. Configure your scene lights and shadows  

---
# ⚒️ Usage

1. Attach the `SpriteShadowCaster` component to any GameObject containing a Sprite Renderer  
2. Assign `Mat_Sprite_Shadow` to the Sprite Renderer material slot  
3. Add 3D lights to the scene

   
---
# 📄 License

This project is available under the MIT License.
