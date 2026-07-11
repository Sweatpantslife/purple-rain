# Purple Rain

A first-person action/quest game built in Unity.

## Premise

The protagonist loses everything — career, home, reputation, relationships — after being framed as the fall guy in a large-scale conspiracy. Cast out and hunted, he must travel through a figurative *heaven and hell* to reclaim his life: investigating the people who framed him, breaking the law when the law has abandoned him, solving puzzles and riddles that guard the truth, clearing his name, taking his revenge, and finally stopping the conspirators before they finish what they started.

## Gameplay Pillars

- **First-person action** — visceral, grounded first-person movement and combat/evasion.
- **Investigation** — gather evidence, follow leads, connect the dots on who framed you and why.
- **Puzzles & riddles** — environmental puzzles and riddles gate progress and reveal the truth.
- **Narrative quests** — a quest-driven story arc of falling from grace, descending into hell, and clawing your way back.

See [docs/GAME_DESIGN.md](docs/GAME_DESIGN.md) for the design overview and an index of the full design package.

## Planned Tech

| Area | Choice |
| --- | --- |
| Engine | Unity 6000.5.3f1 |
| Language | C# |
| Rendering | Universal Render Pipeline (URP) |
| Input | Unity Input System |
| Camera | Cinemachine |
| UI | uGUI + TextMeshPro (bundled with uGUI 2.x in Unity 6) |

## Repo Layout

```
Assets/
  Art/          # Models, textures, sprites, VFX source assets
  Audio/        # Music, SFX, ambience
  Materials/    # Materials and shaders
  Prefabs/      # Reusable game objects
  Scenes/       # Unity scenes
  Scripts/      # C# gameplay code
  Settings/     # URP assets, input actions, project-level ScriptableObjects
  UI/           # UI prefabs, sprites, layouts
Packages/       # Unity package manifest
ProjectSettings/# Unity project settings (editor-generated + pinned version)
docs/           # Design documents
```

## Opening the Project

1. Install [Unity Hub](https://unity.com/download) and a Unity **6000.5.3f1** editor (the pinned version in `ProjectSettings/ProjectVersion.txt`).
2. In Unity Hub: **Add** → **Add project from disk** → select this repository's root folder.
3. Open the project. Unity will resolve packages from `Packages/manifest.json` and generate the `Library/` cache on first import.

> **Note:** This repository is a minimal scaffold. It intentionally contains only the package manifest, the pinned editor version, and an empty asset folder structure. Unity will generate the remaining `ProjectSettings/` files, `Packages/packages-lock.json`, and the (git-ignored) `Library/` folder the first time the project is opened in the editor.

> **Git LFS:** `.gitattributes` is pre-configured with LFS filter rules for binary asset types (textures, audio, models, video, fonts, etc.). Install [Git LFS](https://git-lfs.com) (`git lfs install`) before committing binary assets.
