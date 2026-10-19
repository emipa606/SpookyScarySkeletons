# GitHub Copilot Instructions for Spooky Scary Skeletons (Continued)

## Mod Overview and Purpose
The "Spooky Scary Skeletons (Continued)" mod is a continuation of the original mod by KasmexForever. The primary purpose of this mod is to enhance the visual diversity and appeal of the skeletal remains in RimWorld. It replaces the vanilla game’s limited collection of skeletons (two generic skeletons and one skull) with a set of unique skeletons corresponding to each humanoid body type and two varied skull shapes, allowing for a more personalized and thematic representation of deceased pawns.

## Key Features and Systems
- **Skeleton Diversity**: The mod introduces different skeleton graphics for each body type, moving away from the generic skeletal figures of the vanilla game.
- **Skull Variations**: Offers two skull shapes instead of one, adding nuance to the in-game skeletal remains.
- **Seamless Integration**: Designed to integrate smoothly with existing game mechanics and visual styles.

## Coding Patterns and Conventions
- **C# Structure**: The project consists of three primary C# scripts. Each serves a distinct function, such as defining types and handling graphic replacements.
- **Naming Conventions**: Classes and functions are descriptively named, focusing on clarity and maintaining consistency with RimWorld’s typical naming schemes.
- **Organization**: The project's files are organized by functionality, supporting ease of navigation and maintenance.

## XML Integration
- **XML Definitions**: The mod uses XML definitions to declare skeleton and skull variants, which are loaded into the game via RimWorld's definition system. Key XML files include `HeadTypes.xml` for defining different skeletal types.
- **Patching Via XML**: The `Core.xml` file employs Harmony patches to modify existing game behavior, ensuring that the new skeletons and skulls are utilized appropriately.

## Harmony Patching
- **Dependency on Harmony**: The mod requires Harmony (dependency: brrainz.harmony) to patch the game's existing methods and integrate the new graphic replacements seamlessly.
- **Patching Techniques**: Utilizes postfix patches (e.g., `PawnGraphicSet_ResolveAllGraphics.cs`) to enhance or extend original game methods without directly modifying the core game files, making the mod adaptable and minimizing conflicts with other mods.

## Suggestions for Copilot
To leverage GitHub Copilot’s code-generation capabilities effectively in the development of this mod, consider the following:
- **Function Templates**: Generate templates for new functions or methods that require consistency with existing code structure.
- **Complex Logic Assistance**: Use Copilot to draft complex logic scenarios or when unfamiliar with a particular C# or XML construct.
- **Error Handling**: Implementing suggestions for error handling routines to catch and log issues related to graphic replacements or other mod functionalities.
- **XML Snippets**: Auto-generate XML snippets for defining new head or body types as expansions to the mod’s current offerings.
- **Harmony Patch Examples**: Request patch examples from Copilot to ensure Harmony is implemented optimally.

These practices can enhance productivity and streamline the development process for updates or expansions of the Spooky Scary Skeletons mod.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

