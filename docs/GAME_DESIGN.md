# Purple Rain — Game Design Overview (v1.0)

> **Top-level index of the design package.** This document holds the elevator pitch, the design pillars, and an annotated map of every design document. The v0.1 design brief that used to live here has been superseded scene-by-scene by the full package; where a section below points elsewhere, the pointer is the content. Canon priority everywhere: `docs/narrative/` first, then `docs/storyboard/`, then `docs/gameplay/`.
>
> **Spoiler note:** this overview is spoiler-light, but almost everything it links to is not. Playtesters and blind contractors should read only STORY.md §1–§3 and nothing else in the package.

## Elevator Pitch

*Purple Rain* is a first-person neo-noir investigation game (Unity 6). Adam Vale, an ordinary city water engineer, is framed as the mastermind of a vast data-falsification conspiracy and loses his job, home, wife, and name in a single week. He falls into the drowned under-city of rain-soaked Meridian and — guided by the people the city discarded — investigates the conspiracy from beneath, learning to break the law the law is being used against him, and to read the cipher-language of the city's true rulers. He can't out-document the people who write the documents; in the end, during a hundred-year storm, he makes the one witness they can never frame take the stand: the water itself.

Tone: grounded neo-noir thriller with mythic undertones — figurative heaven and hell, violet-and-sodium palette, administrative horror. Full tone spec and reference points (The Fugitive, Monte Cristo, Dishonored, Deus Ex, *Chinatown*): [narrative/STORY.md](narrative/STORY.md) §7.

## Design Pillars

1. **First-person action** — grounded movement, evasion, and scarce, physical, priced confrontation. Tense and personal; escape is the winning move. (Spec: [gameplay/GAMEPLAY.md](gameplay/GAMEPLAY.md) §2.)
2. **Investigation** — evidence gathering, surveillance, document trails; the player assembles the conspiracy piece by piece through the **Case File**. Adam's superpower is *reading water* — the investigation mechanics are his profession, diegetically.
3. **Puzzles & riddles** — diegetic, two families: the Vestry's century-old cipher culture (hymn-number minutes, plaques, stained glass — *the city is the ledger*) and Adam's hydraulics grammar (tracer logic, valve networks, pressure maps). (Compendium: [gameplay/PUZZLES.md](gameplay/PUZZLES.md).)
4. **Narrative quests** — a quest-driven five-act structure where story beats, choices, and consequences carry the experience; no morality meter, choices are remembered, not scored.

The core loop (INVESTIGATE → ACT → PUZZLE → CONSEQUENCE/REVEAL) survives from the original brief and is now fully specified, including its per-act shifts, in [gameplay/GAMEPLAY.md](gameplay/GAMEPLAY.md) §1.

## Story & Act Structure

The story summary and act table that used to live here are superseded. The master scriptment is **[narrative/STORY.md](narrative/STORY.md)** — logline and synopsis in §1–§2, the full truth from §4, scene-level beats in Part Four. The act names and Act 0–IV numbering are unchanged and canonical:

**Act 0 — Grace · Act I — The Fall · Act II — Hell · Act III — Purgatory · Act IV — Reckoning** (58 scenes, A0-S01…A4-S11).

Structure is hub-based from Act II: the **Lantern** shelter is the safehouse hub, with districts unlocked by Kray-passage through the flooded tunnels; Acts 0–I are linear. (STORY.md §10; systems in GAMEPLAY.md §6; safehouse state ladder in §4.2.)

## The Design Package — Annotated Map

### docs/narrative/ — the canon (Phase 1; highest authority)

- **[STORY.md](narrative/STORY.md)** — the master scriptment: logline, synopsis, world, the full conspiracy (§4), character arcs, all five acts scene by scene, themes, title (§8), and the design-hook resolutions (§10). Read first, before anything else in the package; §1–§3 are the only spoiler-safe pages.
- **[MYSTERY_LOGIC.md](narrative/MYSTERY_LOGIC.md)** — the clue web: every clue C-01…C-35 (planted / surface read / true meaning / payoff), red herrings RH-01…08 with debunk beats, reveal dependency graph for R0–R5, and the fair-play audit. Read before touching any scene, dialogue, or quest that plants or pays off a clue.
- **[TIMELINE.md](narrative/TIMELINE.md)** — true chronology of the conspiracy (1856–present, T-* events), the game-present calendar, the frame's month-by-month construction schedule, and the discovery map (order of events vs. order the player learns them). Read when dating anything, or when writing flashback/backstory content.

### docs/storyboard/ — production storyboard (Phase 2)

- **[SCENES.md](storyboard/SCENES.md)** — the complete scene graph: all 58 scenes in play order with staging depth (beats, characters, locations, clue plants per scene). The spine for cinematics, level, and quest work; adds staging, not canon — conflicts resolve toward narrative/.
- **[CHARACTERS.md](storyboard/CHARACTERS.md)** — the character bible (CH-*): appearance briefs for concept art/casting/VO, plus fair-play tracks for the five load-bearing deception characters that any new dialogue must preserve. Read before writing or depicting any character.
- **[LOCATIONS.md](storyboard/LOCATIONS.md)** — the location bible: all 30 registered locations (LOC-*) at blockout-brief depth, grouped by story region, including the palette doctrine (violet in water is plot information, never decoration). Read before environment, level, or lighting work.

### docs/gameplay/ — systems and per-scene gameplay (Phase 2)

- **[GAMEPLAY.md](gameplay/GAMEPLAY.md)** — core mechanics and systems: the loop, combat, investigation and tracer mechanics, crime verbs, **Heat** (notoriety without a morality meter), the three choice valves, hub structure, and design guardrails. Canonical system names live here; read before speccing any mechanic, UI, or code identifier.
- **[PUZZLES.md](gameplay/PUZZLES.md)** — the puzzle compendium: every puzzle and riddle (P-*), mapped to its scene, with solve logic, hint ladders, and failure models. Read alongside SCENES.md when building any solve-obstacle.
- **[SCENE_FLOW.md](gameplay/SCENE_FLOW.md)** — the Phase 2→3 bridge: one gameplay entry per scene, all 58, tying SCENES.md's beats to GAMEPLAY.md's systems (objectives, verbs, failure states, teaching beats). Read when implementing a specific scene.

## ID Conventions (canonical across all docs)

| Prefix | Meaning | Defined in |
| --- | --- | --- |
| `A<act>-S<scene>` | Scene/beat ID, `A0-S01`…`A4-S11` (58 scenes) | STORY.md Part Four; graph in SCENES.md |
| `CH-*` | Character ID (e.g. `CH-adam`, `CH-cordell`) | CHARACTERS.md |
| `LOC-*` | Location ID (e.g. `LOC-lantern`) — 30 locations | LOCATIONS.md |
| `C-##` | Clue, `C-01`…`C-35` | MYSTERY_LOGIC.md §1 |
| `RH-##` | Red herring, `RH-01`…`RH-08` (each with a debunk beat) | MYSTERY_LOGIC.md |
| `R0`–`R5` | Reveal ladder | STORY.md §4.7 |
| `P-*` | Puzzle ID (e.g. `P-A0-S03-1`, keyed to its scene) | PUZZLES.md |
| `T-*` | Timeline event (e.g. `T-1988`) | TIMELINE.md |

Use IDs verbatim; never coin new ones outside their defining document.

## Resolved Open Questions

The v0.1 brief's open questions are settled (resolutions canonized in [STORY.md §10](narrative/STORY.md)):

- **Riddle authorship** — diegetic: the riddles are **the Vestry's** own cipher culture (hidden business in consecrated plain sight), plus Adam's hydraulics grammar. See STORY.md §3.3.
- **Title** — the title is the oldest clue in the game; five nested meanings, revealed in order. See STORY.md §8.
- **The "heaven" ending** — heaven is a beginning, not a restoration: a canonical single spine with three tracked choice valves (A3-S10 Krebs, A4-S06 Marr, A4-S08 Cordell) plus the A2-S13 commitment beat, shading epilogue variants rather than branching plot.
- **Structure** — hub-based: the Lantern as safehouse hub from Act II, districts unlocked by Kray-passage; A0–A1 linear. Systems in GAMEPLAY.md §6.
- **Morality system** — no meter; the three valves are remembered by characters and epilogue text, not scored. **Heat** is operational awareness, deliberately amoral (GAMEPLAY.md §3).
- **Combat depth** — evasion-first; combat is scarce, physical, close, and expensive, with authored exits and hard sanctuary exclusions (GAMEPLAY.md §2).
- **Scope** — core path ≈ 14 h across five acts (pacing estimate in STORY.md Part Four); content budget tracks the 58-scene graph.
