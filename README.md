# Flappy Bird Clone (Unity)

A simple Flappy Bird–style game built with **Unity** and **C#**, focusing on core gameplay mechanics, physics-based movement, and clean project structure.

---

## 🎮 Gameplay Overview
- Tap / press to make the bird fly upward
- Navigate through randomly generated pipes
- Score increases when passing through pipe gaps
- Game Over on collision or leaving the screen
- Restart supported without restarting the application

---

## 🛠 Tech Stack
- **Game Engine:** Unity
- **Language:** C#
- **IDE:** Visual Studio Community
- **Version Control:** Git + GitHub (SSH)

---

## ✨ Features
- Physics-based bird movement using Rigidbody2D
- Procedural pipe spawning
- Collision detection and scoring system
- Game state management (Start / Playing / Game Over)
- Clean Unity project structure with proper `.gitignore`

---

## 🎯 Controls
| Action | Key |
|------|----|
| Fly / Jump | Space |


---

## 📂 Project Structure
```text
Assets/
├─ Scripts/
│  ├─ BirdController.cs
│  ├─ PipeSpawner.cs
│  ├─ GameManager.cs
│  └─ ScoreManager.cs
├─ Scenes/
└─ Prefabs/
ProjectSettings/
.gitignore
