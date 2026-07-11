# Graybox Scene Manifest — A2-S03 "The Name Trade" (P-A2-S03-1)

> **Scope:** blockout data for the vertical-slice scene `A2S03_NameTrade_Graybox`.
> Canon sources: [SCENES.md A2-S03](../storyboard/SCENES.md), [PUZZLES.md P-A2-S03-1](../gameplay/PUZZLES.md), [LOCATIONS.md LOC-undercroft § "The water-feed junction"](../storyboard/LOCATIONS.md), [SCENE_FLOW.md A2-S03](../gameplay/SCENE_FLOW.md).
> Assembly steps that consume this manifest: [VERTICAL_SLICE.md](VERTICAL_SLICE.md).

## Conventions

- **Units:** meters. **Axes:** +Z = "north" (deeper into the Undercroft), +X = east, Y up. World origin `(0,0,0)` = center of the junction-chamber floor at walk level.
- All blockout geometry is Unity primitives (Cube / Cylinder / Quad) with graybox materials (§6). Floors sit with their top face at Y=0 (floor cubes are 0.2 thick, centered at Y=-0.1).
- Rotations are Euler degrees, scales are localScale. Unlisted rotation = (0,0,0), unlisted scale = (1,1,1).
- Everything static (floors, walls, pipes, pedestals) should be marked **Static** for baked/realtime GI; leave interactables, gate, lights, and triggers non-static.

## 1. Spatial overview

```
                         N (+Z)
        ┌──────────────────┐
        │  REVEAL CHAMBER  │  z 18..26  — the leachate wall (altar staging)
        │   x -5..5        │
        └───────┬──────────┘
                │ NORTH GALLERY (corridor, x -2..2, z 6..18)
                │   FlowGrate blocks at z=8 until puzzle solves
        ┌───────┴──────────┐
        │ JUNCTION CHAMBER │  z -6..6, x -7..7 — the four-valve puzzle
        │  (V1..V4, pipes) │
        └───────┬──────────┘
                │ ENTRY TUNNEL (x -2..2, z -19..-6)
        ┌───────┴──────────┐
        │  NINE'S LANDING  │  z -25..-19 — spawn + Nine proposition trigger
        └──────────────────┘
```

Player path: Landing → tunnel → junction (investigate cues, work the valves) → grate releases → gallery → reveal chamber (violet wall re-lit) → take the sample.

> **Staging deviation (deliberate — do not inherit as canon):** PUZZLES.md P-A2-S03-1 and LOCATIONS.md LOC-undercroft route the approach *past* the leachate wall on the way to the junction (the torchlit pre-pass — SCENE_FLOW.md's "violet sheet crossing the torch beam"). This slice compresses the space and inverts that: the wall is only reachable **after** the solve. The pre-puzzle sighting beat is deferred to the full level build; later level design should restore the route-past-the-wall approach rather than copying this layout.

## 2. Static geometry (all primitive **Cube** unless noted)

| GameObject | Position | Scale | Material | Notes |
|---|---|---|---|---|
| `ENV/Landing/Floor` | (0, -0.1, -22) | (6, 0.2, 6) | M_Floor | spawn zone |
| `ENV/Landing/Wall_S` | (0, 2, -25.15) | (6.6, 4, 0.3) | M_Wall | |
| `ENV/Landing/Wall_W` | (-3.15, 2, -22) | (0.3, 4, 6) | M_Wall | |
| `ENV/Landing/Wall_E` | (3.15, 2, -22) | (0.3, 4, 6) | M_Wall | |
| `ENV/Landing/Wall_N_L` | (-2.5, 2, -19.15) | (1.6, 4, 0.3) | M_Wall | flanks tunnel mouth (gap x −1.7..1.7) |
| `ENV/Landing/Wall_N_R` | (2.5, 2, -19.15) | (1.6, 4, 0.3) | M_Wall | |
| `ENV/Landing/CrouchSoffit` | (2.2, 1.75, -24.3) | (1.6, 0.7, 1.4) | M_Wall | low soffit in the landing's SE corner, underside at Y 1.4 — the crouch/headroom test: duck under it and standing stays blocked until you back out |
| `ENV/Tunnel/Floor` | (0, -0.1, -12.5) | (4, 0.2, 13) | M_Floor | z −19..−6 |
| `ENV/Tunnel/Wall_W` | (-2.15, 2, -12.5) | (0.3, 4, 13) | M_Wall | |
| `ENV/Tunnel/Wall_E` | (2.15, 2, -12.5) | (0.3, 4, 13) | M_Wall | |
| `ENV/Tunnel/Ceiling` | (0, 4.1, -12.5) | (4.6, 0.2, 13) | M_Wall | optional but sells the vault; forces crouch nowhere |
| `ENV/Junction/Floor` | (0, -0.1, 0) | (14, 0.2, 12) | M_Floor | x −7..7, z −6..6 |
| `ENV/Junction/Wall_W` | (-7.15, 2, 0) | (0.3, 4, 12) | M_Wall | |
| `ENV/Junction/Wall_E` | (7.15, 2, 0) | (0.3, 4, 12) | M_Wall | |
| `ENV/Junction/Wall_S_L` | (-4.5, 2, -6.15) | (5, 4, 0.3) | M_Wall | south gap x −2..2 = tunnel mouth |
| `ENV/Junction/Wall_S_R` | (4.5, 2, -6.15) | (5, 4, 0.3) | M_Wall | |
| `ENV/Junction/Wall_N_L` | (-4.5, 2, 6.15) | (5, 4, 0.3) | M_Wall | north gap x −2..2 = gallery mouth |
| `ENV/Junction/Wall_N_R` | (4.5, 2, 6.15) | (5, 4, 0.3) | M_Wall | |
| `ENV/Junction/Pipe_WestIntake` (Cylinder) | (-6, 1.2, 3) | (0.5, 1.5, 0.5) | M_Pipe | rotation (0,0,90) — runs along X out of the west wall |
| `ENV/Junction/Pipe_EastBypass` (Cylinder) | (6, 1.2, 3) | (0.5, 1.5, 0.5) | M_Pipe | rotation (0,0,90) |
| `ENV/Junction/Pipe_NorthMain` (Cylinder) | (0, 3.2, 5.8) | (0.4, 1.2, 0.4) | M_Pipe | rotation (90,0,0) — overhead main into the gallery |
| `ENV/Junction/Standpipe_Relief` (Cylinder) | (-3, 1.5, -4) | (0.5, 1.5, 0.5) | M_Pipe | vertical relief drain |
| `ENV/Junction/SedimentFan` | (-5, 0.01, 3) | (2, 0.05, 2) | M_Sediment | rust-red stain fanning from the west pipe — the fouled-branch cue |
| `ENV/Gallery/Floor` | (0, -0.1, 12) | (4, 0.2, 12) | M_Floor | z 6..18 |
| `ENV/Gallery/Wall_W` | (-2.15, 2, 12) | (0.3, 4, 12) | M_Wall | |
| `ENV/Gallery/Wall_E` | (2.15, 2, 12) | (0.3, 4, 12) | M_Wall | |
| `ENV/Gallery/Ceiling` | (0, 4.1, 12) | (4.6, 0.2, 12) | M_Wall | the gallery should feel tighter/darker |
| `ENV/Reveal/Floor` | (0, -0.1, 22) | (10, 0.2, 8) | M_Floor | z 18..26 |
| `ENV/Reveal/Wall_W` | (-5.15, 2, 22) | (0.3, 4, 8) | M_Wall | |
| `ENV/Reveal/Wall_E` | (5.15, 2, 22) | (0.3, 4, 8) | M_Wall | |
| `ENV/Reveal/Wall_N` | (0, 2, 26.15) | (10.3, 4, 0.3) | M_Wall | back wall behind the leachate face |
| `ENV/Reveal/Wall_S_L` | (-3.5, 2, 18.15) | (3, 4, 0.3) | M_Wall | south gap x −2..2 = gallery mouth |
| `ENV/Reveal/Wall_S_R` | (3.5, 2, 18.15) | (3, 4, 0.3) | M_Wall | |
| `ENV/Reveal/LeachateWall` | (0, 2, 25.9) | (8, 4, 0.1) | M_Leachate | **the wall staged like an altar** — violet emissive face |

## 3. Interactables & puzzle objects

Each valve = an **empty root at unit scale** (so the children keep their authored world sizes — a scaled Cube parent would shrink and swallow the wheel) with two primitive children: a `Pedestal` Cube standing on the floor and a wheel Cylinder named `Handle` at the pedestal top. `ValveInteractable` goes on the **root** — the Interactor finds it from the pedestal's collider via `GetComponentInParent`. Colliders come with the primitives; keep them, non-trigger.

| GameObject | Position | Scale | Components / serialized fields |
|---|---|---|---|
| `PUZZLE/Valve_FouledIntake` (empty) | (-6.3, 0, 1.5) | — | `ValveInteractable`: Valve Name `West Intake — Upper Gallery`, **Is Open ✔ (starts OPEN)**, Handle = `Handle` child, Verb auto (Use) |
| ├ `Pedestal` (Cube child) | local (0, 0.6, 0) | (0.3, 1.2, 0.3) | M_Pipe — stands on the floor, top at Y 1.2 |
| └ `Handle` (Cylinder child) | local (0.2, 1.2, 0) | (0.6, 0.05, 0.6) | rotation (0,0,90) — 0.6 m wheel facing the room, proud of the pedestal's east face |
| `PUZZLE/Valve_EastBypass` (empty) | (6.3, 0, 1.5) | — | `ValveInteractable`: `East Bypass — Lower Gallery`, Is Open ✗ (starts CLOSED); Pedestal child as above; Handle child local (−0.2, 1.2, 0), scale (0.6, 0.05, 0.6), rotation (0,0,90) |
| `PUZZLE/Valve_NorthMain` (empty) | (-3.5, 0, 5.7) | — | `ValveInteractable`: `Distribution Main — North Gallery`, Is Open ✗; Pedestal child as above; Handle child local (0, 1.2, −0.2), scale (0.6, 0.05, 0.6), rotation (90,0,0) |
| `PUZZLE/Valve_ReliefDrain` (empty) | (-3, 0, -3.4) | — | `ValveInteractable`: `Relief Drain — Pressure Head`, **Is Open ✔**; Pedestal child as above; Handle child local (0, 1.25, 0), scale (0.6, 0.05, 0.6) — horizontal wheel resting on the pedestal top |
| `PUZZLE/WaterFeedPuzzle` (empty) | (0, 0, 0) | — | `WaterFeedPuzzle` — requirements: FouledIntake **mustBeOpen ✗**, EastBypass **✔**, NorthMain **✔**, ReliefDrain **✗**; Beat Channel `SBC-Main`, Solved Beat `BEAT-A2S03-FEED-RESTORED` |
| `PUZZLE/FlowGrate` (Cube) | (0, 1.5, 8) | (3.8, 3, 0.2) | M_Grate. `ExaminePoint`: name `Jammed Grate`, text *"An iron grate, seized by decades of pressure differential. Nothing mechanical wrong with it — the junction feed is fighting itself. Re-balance the network and it will swing."* |
| `PUZZLE/LeachateWallReveal` (empty) | (0, 0, 20) | — | `LeachateWallReveal` — Puzzle = `WaterFeedPuzzle`; Enable On Reveal = [`LIGHTS/L_Reveal_1`, `LIGHTS/L_Reveal_2`]; Disable On Reveal = [`PUZZLE/FlowGrate`]; Unlock On Reveal = [`CLUES/Pickup_LeachateSample`] |

## 4. Investigation & evidence layer

| GameObject | Position | Scale | Components / serialized fields |
|---|---|---|---|
| `CLUES/Examine_SedimentFan` (Cube) | (-5, 0.4, 3) | (0.5, 0.8, 0.5) | M_Debug (or disable MeshRenderer; keep collider). `ExaminePoint`: name `Sediment fan`, text *"Rust-red sediment, fanned downstream of the west intake. The fouling rides in on that leg — close it and the feed can breathe."*, Log As Evidence `EV-A2S03-OBS-FOULED` |
| `CLUES/Examine_DatumLine` (Cube) | (6.9, 1.6, -2) | (0.1, 0.6, 1.5) | on the east wall. `ExaminePoint`: name `High-water datum line`, text *"A datum line scored into the brick, 1911. The junction has drowned before; the water remembers how high."*, Log As Evidence `EV-A2S03-OBS-DATUM` |
| `CLUES/Examine_PressureGauge` (Cube) | (-2.6, 1.6, -3.4) | (0.3, 0.3, 0.1) | beside the standpipe. `ExaminePoint`: name `Pressure gauge`, text *"Needle at zero. The relief drain is bleeding the head — close it last, or first; the network doesn't care about order, only states."* |
| `CLUES/Pickup_LeachateSample` (Cylinder) | (0, 0.5, 24.5) | (0.3, 0.5, 0.3) | M_Leachate. `EvidencePickup`: Item `EV-A2S03-SAMPLE`, Beat Channel `SBC-Main`, Collected Beat `BEAT-A2S03-SAMPLE-LOGGED`. Starts **locked** (LeachateWallReveal handles it) |

## 5. Triggers, spawn, lights

| GameObject | Position | Scale | Setup |
|---|---|---|---|
| `TRIGGERS/TV_NineIntro` (Cube, IsTrigger, MeshRenderer off) | (0, 1.5, -20) | (5, 3, 2) | `TriggerVolume` (once). onEntered → `HudMessageUI.Show(string)`: *"Nine: 'Papers cost. Word is the new man reads water. The feed past this junction is fouling — fix it, and we'll talk names.'"* |
| `TRIGGERS/TV_GalleryEnter` (Cube, IsTrigger, MeshRenderer off) | (0, 1.5, 10) | (3.5, 3, 1.5) | `TriggerVolume` (once). onEntered → HudMessage: *"The water sounds different ahead. Cleaner. And the dark has a colour to it."* (only reachable after the grate opens) |
| `TRIGGERS/TV_WallApproach` (Cube, IsTrigger, MeshRenderer off) | (0, 1.5, 21) | (8, 3, 1.5) | `TriggerVolume` (once), Beat `BEAT-A2S03-WALL-SEEN`. onEntered → HudMessage: *"Violet leachate. Live. Sheeting down Works-era brick. The folklore is running in real time."* |
| `PlayerSpawn` (empty marker) | (0, 0, -22) | — | rotation (0,0,0) — faces +Z; place the Player rig here |
| `LIGHTS/L_Landing` (Point Light) | (0, 3, -21) | — | color #FFC46B (lantern amber), range 8, intensity 1.5 |
| `LIGHTS/L_Tunnel` (Point Light) | (0, 3.5, -12) | — | amber, range 9, intensity 1.2 |
| `LIGHTS/L_Junction` (Point Light) | (0, 3.5, 0) | — | amber, range 14, intensity 2 |
| `LIGHTS/L_Gallery` (Point Light) | (0, 3.5, 13) | — | amber, range 8, intensity 0.7 — dimmest room pre-reveal |
| `LIGHTS/L_Reveal_1` (Point Light) | (0, 3, 23) | — | **color #7A3FF2 (violet), range 12, intensity 3 — starts DISABLED** |
| `LIGHTS/L_Reveal_2` (Point Light) | (0, 1.2, 24.8) | — | **violet, range 6, intensity 2 — starts DISABLED** |

Scene lighting: delete the default Directional Light; set Environment ambient to near-black (Lighting window → Environment → Ambient Color ≈ #101018). The Undercroft is "absolute dark held back by lantern amber" — and the violet may come **only** from the reveal lights (palette doctrine: violet in water is plot information, never decoration).

## 6. Graybox materials (URP/Lit unless noted)

| Material | Base color | Notes |
|---|---|---|
| `M_Floor` | #4A4A4A | |
| `M_Wall` | #5C5148 | brick-brown gray |
| `M_Pipe` | #3E4E52 | |
| `M_Grate` | #2E2E2E | metallic 0.6 |
| `M_Sediment` | #7A3B2E | the fouled-branch stain |
| `M_Leachate` | #35244D base, **emission #7A3FF2 × 2** | the wall + sample vial |
| `M_Debug` | #00000000 | invisible examine hotspots — **Surface Type = Transparent** (URP/Lit Opaque ignores base-color alpha and would render solid black boxes); or skip the material entirely and disable each hotspot's MeshRenderer, keeping the collider |

## 7. Puzzle solution (designer reference)

State-based, order-free (canon: "multiple valid valve orders reach the same isolation"):

| Valve | Start | Required | Fiction |
|---|---|---|---|
| West Intake — Upper Gallery | OPEN | **CLOSED** | isolate the contaminated leg |
| East Bypass — Lower Gallery | CLOSED | **OPEN** | re-route supply through clean galleries |
| Distribution Main — North Gallery | CLOSED | **OPEN** | feed the network again |
| Relief Drain — Pressure Head | OPEN | **CLOSED** | hold pressure — re-pressurize the feed |

No fail states: wrong states just don't solve — WaterFeedPuzzle reports progress via `onProgressChanged`, surfaced by the `WaterFeedStatusUI` junction-balance readout (see VERTICAL_SLICE.md §5–6). On solve: `BEAT-A2S03-FEED-RESTORED` (R0 begins), grate opens, reveal lights on, sample unlocks. Sample pickup: `BEAT-A2S03-SAMPLE-LOGGED` (the signature the match verb checks for the rest of the game); the wall approach fires `BEAT-A2S03-WALL-SEEN` (C-02 payoff #1).

## 8. ScriptableObject assets (create in editor; see VERTICAL_SLICE.md §4)

| Asset (path under `Assets/Data/`) | Type | Fields |
|---|---|---|
| `Channels/SBC-Main` | Story Beat Channel | Log To Console ✔ |
| `Beats/BEAT-A2S03-FEED-RESTORED` | Story Beat | id `BEAT-A2S03-FEED-RESTORED`; title `The Feed Restored`; desc `The final valve turn re-lights the chamber. R0 begins — this was never just about him.` |
| `Beats/BEAT-A2S03-WALL-SEEN` | Story Beat | id `BEAT-A2S03-WALL-SEEN`; title `The Leachate Wall`; desc `The game's first true image of the title (A2-S03 key shot). C-02 payoff #1 — the folklore is running in real time.` |
| `Beats/BEAT-A2S03-SAMPLE-LOGGED` | Story Beat | id `BEAT-A2S03-SAMPLE-LOGGED`; title `Old Habit, Old Life`; desc `Sample taken, labeled, logged in #42. The signature the match verb checks against for the rest of the game.` |
| `Evidence/EV-A2S03-OBS-FOULED` | Evidence Item | id `EV-A2S03-OBS-FOULED`; title `Sediment fan — west intake`; cat Observation; prov BelowSourced; desc `Rust-red fan downstream of the west leg. The fouling source is upstream-west.` |
| `Evidence/EV-A2S03-OBS-DATUM` | Evidence Item | id `EV-A2S03-OBS-DATUM`; title `High-water datum, 1911`; cat Observation; prov BelowSourced; desc `The junction floods; the brick keeps the record.` |
| `Evidence/EV-A2S03-SAMPLE` | Evidence Item | id `EV-A2S03-SAMPLE`; title `Violet leachate sample`; cat Sample; prov BelowSourced; desc `Live violet leachate off Works-era brick, labeled and dated. The signature every later match reads against.` |
