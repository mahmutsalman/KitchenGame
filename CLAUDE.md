# CodeMonkey4 — Claude Code Rules

## Git Commit Rules

### Package / Asset Imports
Any time a package is imported or a new asset folder is dropped into the project,
commit it in its own isolated commit — separate from script or logic changes.

```
git add Assets/<FolderName>.meta Assets/<FolderName>/
git commit -m "Import <PackageName>"
```

This keeps history readable: asset additions are clearly separated from gameplay code.

### Commit frequency
Commit after every meaningful tutorial step — even small ones. The goal is to be
able to check out any specific moment and have the game in that exact state.

Good examples:
- "Add Player movement script"
- "Add ClearCounter interaction"
- "Wire up input actions to Player"
- "Add KitchenObject ScriptableObject"

### Revisiting old states (detached HEAD workflow)
To go back to any past commit and test without saving changes:

```bash
git checkout <commit-hash>   # visit that point in time
# Open Unity — it regenerates Library automatically (~30s)
# Test freely, change code, nothing is saved

git checkout main            # come back to present, all changes discarded
```

Library/ is excluded from git on purpose — Unity rebuilds it from Assets/ and
ProjectSettings/ every time. Checking out an old commit fully restores the game.

### .meta files rule
Unity uses `.meta` files to track GUIDs — the internal links between assets.
Breaking this rule causes missing references when the project is opened elsewhere.

- **New file added** → always stage both the file AND its `.meta`
- **Existing file modified** → `.meta` is already tracked, nothing extra needed
- **File deleted** → delete both the file AND its `.meta`
- **New folder** → stage the `FolderName.meta` too

Examples:
```bash
# Adding a new script
git add Assets/Scripts/Player.cs Assets/Scripts/Player.cs.meta

# Adding a new prefab
git add Assets/Prefabs/Tomato.prefab Assets/Prefabs/Tomato.prefab.meta

# Modifying an existing scene — .meta already in git, skip it
git add Assets/Scenes/GameScene.unity
```

GameObjects created *inside* a scene (e.g. an empty child Transform) are baked
into the `.unity` file — they are not separate files and need no `.meta`.

### What belongs in each commit type
- **Import commits** — new asset folders, third-party packages, art drops
- **Script commits** — C# scripts, ScriptableObject definitions, logic changes
- **Scene commits** — scene layout changes, prefab wiring, hierarchy edits
- **Settings commits** — ProjectSettings changes, input maps, quality/physics tweaks

## Memory Management

When you discover something valuable for future sessions —
architectural decisions, bug fixes, gotchas, environment quirks —
immediately append it to .claude/memory.md

Don't wait to be asked. Don't wait for session end.

Keep entries short: date, what, why. Read this file at the start
of every session.
