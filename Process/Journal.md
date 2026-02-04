# Week 1 – Make-A-Thing

**Project:** Pac-Man Variation – Inverted Authority Mode  
**Date:** January 15 - 22, 2026 (project start)

## Overview

For my Make-A-Thing project, I created a Pac-Man variation that reverses the traditional player–game relationship because I think people already played too much the original version of Pac-Man. Instead of controlling Pac-Man directly, the player controls the environment by removing and placing walls. Pac-Man becomes an autonomous agent, while the player intervenes indirectly through the system.

## What Worked

Walls cannot be created freely; the player must first remove an existing wall to gain wall stock, which can then be used to block other areas. This immediately introduced meaningful constraints. I also allowed walls to be placed on dot and power-dot tiles without permanently deleting them, which made interventions temporary rather than destructive.

# Week 2 – Unity Basics

**Project:** Basket Movement Exercise

**Date:** January 22 – 29, 2026

## What
This week focuses on getting familiar with Unity’s basic workflow and input system.  
The goal of the exercise is to create a basket that moves horizontally and stays within the screen boundaries.

Because Unity has switched to the new Input System, older keyboard input code did not work as expected. The movement logic was rewritten using the current input structure. The basket can now move left and right smoothly and is constrained within a defined range on the x-axis.

## Why
This exercise is mainly about understanding Unity rather than completing a full game.  
Dealing with input system changes highlighted how important it is to adapt code structure to the engine version instead of relying on outdated examples.

By limiting the scope to movement and boundaries, it became easier to understand how `Update()`, transforms, and frame-based motion work together.

## What Next
The next step is to add falling objects and collision detection so the basket can catch items.  
After that, a simple scoring system and game-over condition will be implemented to turn this into a complete mini-game.

# Week 3 – Unity Basics II

**Project:** Basket Movement Exercise (completed)

**Date:** 1/29 – 2/5, 2026

## Chapters 20–24 — Lecture notes (C# / Unity)
**Variables & Scope**
- Variable = type + name + value
- Common types: `int`, `float` (`f` required), `bool`, `string`
- Unity types: `Vector3`, `GameObject`, `Transform`, `Color`
- Fields: class-level, shared across functions, `public` visible in Inspector
- Local variables: function-level, limited scope
- `null` is common in Unity → always check before use

**Booleans & Conditionals**
- Comparison operators: `==`, `!=`, `>`, `<`, `>=`, `<=`
- Logical operators: `&&`, `||`, `!`
- Use `if / else if / else` for branching logic
- Never confuse `=` (assignment) with `==` (comparison)
- Avoid `float ==` → use ranges or thresholds instead

**Loops**
- `for`: repeat a fixed number of times
- `foreach`: iterate collections (do not modify inside loop)
- `while / do-while`: risk of infinite loops
- `break` exits loop, `continue` skips iteration
- Modulo (`%`) used for periodic checks

**Collections**
- `List<T>`: dynamic size, uses `Count`
- Arrays: fixed size, uses `Length`
- `Dictionary<TKey, TValue>`: fast key-based lookup
- Always check `ContainsKey` before accessing dictionary values
- Never remove elements from a `List` inside `foreach`

**Functions**
- Function structure: `returnType FunctionName(parameters)`
- `void` functions return nothing; `return` exits early
- Parameters ≠ arguments
- Function order does not matter
- Functions use PascalCase naming
- Optional parameters must come last
- Overloading uses same name with different parameters
- `params` allows variable arguments (must be last parameter)
- Recursion requires a base case

**High-Frequency Rules**
- Repetition → `for`
- Collection iteration → `foreach`
- Dynamic data → `List`
- Fixed data → array
- Fast lookup → `Dictionary`
- Always protect against `null`
- Avoid float equality checks



