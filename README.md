# The Hunted House

## SWE 402 – Game Design and Development

A 3D stealth game where the player must escape a haunted house while avoiding ghosts and reaching the exit.

## Chosen Assignment Option

**Option 2: 3D Stealth Game – Haunted House**

## Game Objective

The player starts inside a haunted house and must reach the exit without being detected by the ghosts.

- Reach the exit to win.
- Avoid static and dynamic ghosts.
- If a ghost catches the player, the game restarts.
- Use the main menu to start or quit the game.

## Features Implemented

### Required Features

- 3D haunted-house environment
- Player movement using WASD keys
- Player idle and walking animations
- Cinemachine follow camera
- Static enemies with detection areas
- Dynamic ghosts with movement paths
- Player detection system
- Winning condition when reaching the exit
- Losing condition when caught by a ghost
- Game-ending UI screens
- Background music and sound effects
- Audio for winning and losing events
- Post-processing effects for a darker atmosphere

### Bonus Features

- Main menu with Play and Quit buttons
- AI Ghost using Unity AI Navigation and NavMesh
- Player footstep sounds
- GhostAI prefab for reuse
- Ghost movement sound effects

## Controls

| Key | Action |
|---|---|
| W or Arrow Up | Move forward |
| S or Arrow Down | Move backward |
| A or Arrow Left | Move left |
| D or Arrow Right | Move right |
| Mouse | Select menu buttons |

## How to Open the Project

1. Clone or download this repository.
2. Open Unity Hub.
3. Click **Add**.
4. Select the downloaded project folder.
5. Open the project using Unity 6.

In the Project window, open the main scene:

Assets/Scenes/Main.unity

If the scene has a different name, open the scene containing the main menu.

## How to Run the Game in Unity

1. Open the main menu scene.
2. Press the **Play** button in the Unity Editor.
3. Click the **Play** button in the game’s main menu.
4. Use the WASD keys or arrow keys to move.
5. Avoid the ghosts.
6. Reach the exit to win the game.

## Published Game

The game was built as a WebGL project and published on Unity Play.

Play the game online:

[Play The Hunted House](https://play.unity.com/en/games/e468bff5-7957-42c7-83aa-e45b62eb0511/the-hunted-house)

### How to Play the Published Game

1. Open the Unity Play link.
2. Wait for the game to load.
3. Click the **Play** button.
4. Use WASD or arrow keys to move.
5. Avoid the ghosts.
6. Reach the exit to complete the game.

## AI Navigation

The dynamic GhostAI uses Unity’s AI Navigation system.

- A NavMesh Surface was added to the playable room.
- The walkable area was baked into a NavMesh.
- The GhostAI uses a NavMesh Agent.
- The AIPatrol script selects random destinations.
- The ghost wanders within a defined radius.
- The ghost changes direction after a short period of time.

## Main Menu

The game includes a main menu with:

- Play button
- Quit button
- Game title
- Background visual design

The Play button loads the gameplay scene, while the Quit button exits the application.

## Audio

The game includes:

- Background ambient audio
- Player footstep sounds
- Ghost movement sounds
- Winning sound
- Losing sound
- 3D audio settings for ghost sounds
- Audio Listener attached to the Player

## Game Ending Conditions

### Winning

The player wins by entering the exit area of the haunted house. A winning screen and escape sound are displayed and played.

### Losing

The player loses when detected or caught by a ghost. A caught screen and losing sound are displayed and played, then the scene restarts.

## Repository Contents

Assets/ — Unity scenes, scripts, prefabs, models, UI, and audio

Packages/ — Unity package information

ProjectSettings/ — Unity project settings

README.md — Project documentation

## Main Scripts

PlayerMovement.cs — Controls player movement and animation

GameEnding.cs — Controls winning and losing conditions

AIPatrol.cs — Controls random AI ghost movement

DifficultyButton.cs — Controls difficulty selection buttons

## Technologies Used

- Unity 6
- C#
- Unity Input System
- Unity UI Toolkit
- Cinemachine
- AI Navigation
- NavMesh
- Unity WebGL
- Unity Play

## Credits

This project was created for:

**SWE 402 – Game Design and Development**

The project was developed using Unity and the Unity Learn 3D Stealth Game: Haunted House tutorials.
