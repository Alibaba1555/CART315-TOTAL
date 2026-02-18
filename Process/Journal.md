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
**Date:** January 29 – February 5, 2026

## What
This week builds directly on last week’s basket movement exercise by turning it into a simple playable prototype. Using movement, colliders, and basic instantiation, we created a mini-game where objects fall from the top of the screen and the player controls a basket to catch them.

The basket movement from last week was reused, and falling objects were added using prefabs. Collision detection was implemented so that when an object enters the basket’s collider, it is counted as a successful catch. A basic scoring system was added to track how many objects the player collects.

## Why
The goal of this exploration is to test whether a small set of core mechanics could work together as a system. Specifically, this prototype focuses on how movement, collisions, and score tracking interact in real time.

By keeping the mechanics simple, it was easier to understand how Unity handles collisions, object instantiation, and state changes during gameplay. This also helped clarify how small logic changes can quickly affect the overall feel of a game.

## What Next
If this prototype were to be explored further, the next step would be to introduce variation and challenge. For example, different types of falling objects could be added, including ones that reduce the score or trigger a game-over state.

Other possible extensions include increasing difficulty over time, adding visual or sound feedback when items are caught, or experimenting with different control schemes. 

## Week 3 — Class Notes 

### Three Corners of Prototyping

We discussed three main “corners” of prototyping, with **integration** at the center.

1. **Look & Feel Prototype**  
   Focuses on the game’s appearance and overall visual style.  
   It shows what the game is going to look like and helps attract interest and investment.

2. **Role / Flow Prototype**  
   Focuses on user actions and steps.  
   It answers questions like:  
   - If the player clicks this button, what happens next?  
   - If they choose a different option, what is the next step?  
   Examples include task flows such as taking notes or creating tasks.

3. **Implementation / Technical Prototype**  
   Focuses on technology and feasibility.  
   The main question is whether the idea can actually work with the available tools and technology.

These three areas meet in the center through **integration**.

### Why Start From These Three Corners?

- Faster and cheaper than building a full product  
- Helps generate interest early  
- Allows early testing of whether a game or product could be successful  

---

### Prototype Goals

1. **Understand**  
   - The problem  
   - The target audience  
   - The proposed solution  

   Example:  
   The personal transport devices around 2016 failed partly because they were not tested in extreme or real-world conditions. They assumed wide sidewalks, but many European cities have narrow streets and stairs, making the product impractical and expensive.

2. **Communicate**  
   - Use sketches or simple visuals to explain ideas clearly  
   - Helps teams and stakeholders understand the concept quickly

3. **Test and Improve**  
   - Observe how people react to the prototype  
   - Test whether users can understand where to go or what to do  
   - Example: user guidance in games or platforms like Amazon

---

### Prototype Fidelity

1. **Low Fidelity** — test basic assumptions  
   - Paper prototypes  
   - Storyboards  
   - Wireframes  
   - Simple circuit building  

2. **Mid Fidelity** — more refined assumptions  
   - Clickable prototypes  
   - Style guides  
   - Coded prototypes  
   - Tools like InVision or Adobe XD  

3. **High Fidelity** — small details  
   - Button size  
   - Button color  
   - Visual polish and fine interactions  

---

### Types of Fidelity

- Visual  
- Breadth (how much of the system is covered)  
- Depth (how detailed each part is)  
- Interactivity  
- Data model (content)

---

### Choosing Fidelity

The type and level of fidelity should be chosen based on the question being asked.  
For example: *“How does a user enter this system?”* requires different fidelity choices than *“Is this button color readable?”*.

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

# Week 4 – Breakout Prototype
**Project:** Breakout (2D)

**Date:** February 5 – February 12, 2026

## What
This week we focused on restructuring the ball system so that it becomes the central controller of scoring, pacing, and round resets for the breakOut game.
The ball now manages:

- Scoring system: each brick now awards points when hit, so every successful bounce has a clear reward. Players gain points when the ball hits the left or right wall.

- The ball resets to the center after a point is scored

- Lives / penalty: when the ball goes out of bounds, the player loses a life. This turns “missing the ball” into a meaningful consequence instead of just a reset.

- The launch direction is randomized each round

- Different bounce behavior (material-based): we added collision logic that changes feedback and speed depending on what the ball hits. In my OnCollisionEnter2D, I used tags like "Wall" and "Paddle" to trigger different sound pitch.

- UI + ending state: I added a life bar / life display, a Game Over screen, and a final score display so the game has a clear endpoint and summary of performance.

Overall, the prototype now supports a basic loop: hit bricks → gain score → try not to lose lives → game over → show final score. Compared to previous weeks, the prototype feels more like a playable game rather than just a physics experiment.

## Why
My goal this week was to introduce structure and pacing.

- Adding scoring gives players a clear objective. Points turn brick hits into measurable progress, which helps the player understand what “good play” looks like and motivates improvement. 

- Lives create pressure and force the player to read the ball’s movement more carefully. Without a penalty, missing the ball doesn’t matter, and the game feels flat.

- Adding resets introduces rhythm between rounds.

- Adding a short delay before relaunch reduces chaos and makes the game easier to read.

- Even small changes like sound variation helped make different interactions feel intentional.

Overall, I wanted to move from “objects colliding” to a system that has beginnings, endings, and measurable progress. And Game Over + final score gives closure.

## What Next
If I were to continue improving this game in the future, I could add: 

---

### 1. Gameplay Mechanics Improvements

#### Progressive Difficulty
- Gradually increase ball speed after each successful paddle hit  
- Introduce a maximum speed cap to prevent loss of control  
- Create escalating tension over time  

#### Brick Variations
- Strong bricks (require multiple hits)  
- Speed-altering bricks  
- Special bricks that trigger multi-ball  

#### Power-Ups (This could be a time-limited effect when player breaks some special bricks.)
- Paddle extension  
- Slow motion effect  
- Multi-ball mode  
- Temporary shield  

#### Combo System
- Reward consecutive hits without losing a life  
- Add score multipliers for skilled play  

---

### 2. Game Structure Improvements

#### Game Manager System (structrue)
- Separate ball physics from scoring and game state logic  
- Improve modularity and scalability  

#### Clear Game States
- Start Screen  
- Countdown  
- Playing  
- Point Scored  
- Game Over  
- Restart  

#### Win Conditions
- First to 10 points for example  
- Clear end-of-game resolution  

#### Level System
- Different brick layouts  
- Increasing difficulty per level  

---

### 3. Player Experience Enhancements

#### Visual Feedback
- Particle effects on brick hit  
- Screen shake on impact  
- Flash effect when losing a life  

#### Audio Layering
- Scoring sound  
- Game over sound  
- Dynamic background music based on intensity  

#### UI Animation
- Animated score updates  
- More expressive life bar  

#### Pacing Control
- Adjust delay timing between rounds  
- Experiment with tempo variations  


# Week 5 – Animation as Gameplay Mechanic
**Project:** Parkour / Platforming Test Game (Unity)
**Date:** February 12 – February 19, 2026

## What
This week I built a small parkour prototype in Unity, mainly as a personal test project to apply what we learned about animation last week. Instead of treating animation as “just visuals,” I tried to make it part of the actual gameplay loop.

The opening area is set on a fishing boat. The character starts on the deck, and the boat has a looping rocking animation to imitate waves. It’s a simple idea, but it immediately changes how the player experiences movement: even standing still feels slightly unstable, and jumping has a different “timing” compared to a flat ground. I liked that it communicates the environment without any explanation, the player feels the sea, not just sees it.

After that, I also added floating wood pieces in the ocean as the main platforming path. Each piece has an animation that makes it drift and bob up and down, and sometimes slide a little side-to-side. Visually it looks more natural (like objects actually floating), but functionally it becomes a moving platform system. The player has to step onto these pieces to cross, so the animation becomes a real challenge: you have to watch the pattern, wait for the right moment, and commit to a jump.

One thing I paid attention to is that the motion can’t be “random” if it’s meant to be playable. If the platform moves unpredictably, it stops feeling like a skill-based obstacle and starts feeling like luck. So I kept the motion looped and readable, and I tried to make the rhythm consistent enough that a player can learn it after failing once or twice.
<p align="center">
  <img src="images/01.gif" width="48%" />
  <img src="images/02.gif" width="48%" />
</p>

## Why
I chose to focus on animation because I realized I often treat it as an “extra” that comes after mechanics are done. But in a lot of games I enjoy, moving environments are part of what makes the gameplay interesting, not because they look good, but because they create timing, tension, and decision-making. This week I wanted to test whether I could build that feeling using Unity’s animation workflow.

The fishing boat is a good example. The rocking doesn’t just decorate the scene, it sets the mood and teaches a rule: the ground can shift. It also creates a small psychological effect. Even though it’s subtle, it changes how confident you feel when you move. It makes the space feel less “safe,” which fits the ocean theme and makes the start of the game feel more alive.

The animation of the floating wood platforms makes the world feel believable, but it also forces the player to think differently. On a static platform, you can jump whenever you want. On a moving platform, you have to observe first, then act. That extra step is important because it changes the player from “just moving” into “reading the environment.” I think that’s a big part of what makes platforming feel engaging rather than repetitive.

This also made me think about how design systems can overlap. Normally, you’d separate “look” and “mechanics,” but here they become the same thing. The movement pattern is both a visual language (waves, floating) and a gameplay rule (timing, difficulty). When those two match, the game feels more coherent, and the player doesn’t need tutorials to understand what’s happening.

So the deeper takeaway for me is: animation can be used as a design tool, not only for polish. It can control pacing, difficulty, and even the emotional tone of a space.
<img src="images/03.gif" width="100%" />

## What next
If I continue developing this prototype, I want to explore more ways to make animation-driven environments feel intentional and “designed”.

One direction is to expand the level design around animated obstacles:

- platforms that move in different cycles (slow vs fast, vertical vs horizontal)

- “safe” timing windows that reward patience and observation

- sections where the movement gradually becomes more complex, so difficulty ramps naturally

Another direction is to apply this idea to other genres, especially the kinds of projects I’m interested in long-term. I can imagine using animation for a moving maze where corridors shift over time, forcing the player to memorize patterns or wait for openings. Or a puzzle game where the environment is basically a clock, the level changes state through animation cycles and the player has to solve it by syncing their actions with the world.

I also want to push it in a more atmospheric direction. In a future project (like a horror exploration or “Backrooms” style space), animation doesn’t have to be obvious. Subtle motion can make a place feel unsettling: walls that slightly drift, lights that pulse, objects that sway even when there’s no wind. If that motion is also tied to gameplay (ex: timing doors, shifting paths, hiding routes), it could make the experience feel more immersive and less like “a set of static rooms.”

On the technical side, I want to get better at connecting animation systems with gameplay logic. Right now I’m using looping animations, but next I want to test:

- using Animator states to change platform behavior (normal → unstable → safe)

- triggering animation phases based on player proximity

- mixing animation with physics carefully so it still feels consistent

The main goal is to keep developing the idea that animation is not separate from mechanics. This week was my first attempt at that, and it made me more interested in designing worlds where motion is part of the rules, not just decoration.