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

### What belongs in each commit type
- **Import commits** — new asset folders, third-party packages, art drops
- **Script commits** — C# scripts, ScriptableObject definitions, logic changes
- **Scene commits** — scene layout changes, prefab wiring, hierarchy edits
- **Settings commits** — ProjectSettings changes, input maps, quality/physics tweaks
