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

### What belongs in each commit type
- **Import commits** — new asset folders, third-party packages, art drops
- **Script commits** — C# scripts, ScriptableObject definitions, logic changes
- **Scene commits** — scene layout changes, prefab wiring, hierarchy edits
- **Settings commits** — ProjectSettings changes, input maps, quality/physics tweaks
