# Vertical Slice — Assembly Guide (A2-S03 "The Name Trade")

> **Status: the scene is now pre-built.** `Assets/Scenes/A2S03_Undercroft.unity` was
> authored directly as Unity YAML (branch `feat/a2s03-scene-assembly`) together with the
> graybox materials (`Assets/Materials/Graybox/`), the 7 data assets (`Assets/Data/`),
> and all puzzle/UI wiring from the manifest — no manual editor assembly is required.
> The manual, step-by-step build below is kept as a **fallback appendix** in case the
> pre-built scene needs to be rebuilt or audited by hand.

## Playing the pre-built scene

1. Pull the branch into a **clean checkout** (no uncommitted locally generated `.meta`
   files; if Unity reports GUID conflicts after switching branches, close Unity and
   delete `Library/` so the import cache rebuilds).
2. Open the project in Unity 6000.5.3f1 and open `Assets/Scenes/A2S03_Undercroft.unity`.
3. Press Play. Run the test checklist in §7 below — spawn is on Nine's landing at
   `(0, 0, -22)`, facing the tunnel.

Differences from the manual build (deliberate):

- The scene file is named `A2S03_Undercroft.unity` (not `A2S03_NameTrade_Graybox.unity`).
- The camera uses the Cinemachine wiring (§4's "optional, recommended" variant):
  **CinemachineBrain** on the root-level Main Camera plus a `CM_FirstPerson`
  **CinemachineCamera** (Tracking Target = `Player/CameraPivot`, Hard Lock To Target +
  Rotate With Follow Target) instead of parenting the camera under the pivot.
- The examine hotspots keep their colliders but have their MeshRenderers disabled (the
  manifest's §6 alternative for `M_Debug`); `M_Debug` is still authored as a transparent
  URP/Lit material for future use.
- The scene is registered in Build Settings alongside `SampleScene`.

---

# Appendix — manual assembly (fallback)

> **Goal:** assemble the playable graybox of scene **A2-S03** / puzzle **P-A2-S03-1** in the Unity editor in ~30 minutes, from the code on this branch plus [GRAYBOX_A2S03_MANIFEST.md](GRAYBOX_A2S03_MANIFEST.md).
> **Project:** Unity **6000.5.3f1**, URP 17.5, Input System 1.19.0 (project is already set to the new Input System only), Cinemachine 3.1.7, uGUI 2.5.0 — all already in `Packages/manifest.json`.

## 0. First open (2 min)

1. Open the project in Unity 6000.5.3f1. Unity will import the new files under `Assets/Scripts/`, `Assets/Input/`, and generate their `.meta` files.
2. **Commit the generated `.meta` files** — this repo commits metas, but the new files were authored outside the editor, so Unity must mint their GUIDs (never hand-write metas).
3. Confirm the console is clean: `PurpleRain.Runtime.asmdef` should compile with no errors (it references `Unity.InputSystem`, `Unity.Cinemachine`, `UnityEngine.UI`).

## 1. Scene + materials (4 min)

1. `File → New Scene` (Basic URP template) → save as `Assets/Scenes/A2S03_NameTrade_Graybox.unity`.
2. Delete the default **Directional Light**. Lighting window → Environment: set Ambient Color ≈ `#101018` (near-black), no skybox contribution needed for graybox.
3. Create the 7 materials from **manifest §6** in `Assets/Materials/Graybox/` (URP/Lit; for `M_Leachate` enable Emission, set emission color `#7A3FF2`, intensity ~2; for `M_Debug` set **Surface Type = Transparent** so the alpha-zero base color actually renders invisible — Opaque ignores alpha — or skip it and disable the examine hotspots' MeshRenderers instead).

## 2. Blockout geometry (8 min)

Build **manifest §2** exactly: create empty organizers `ENV`, `PUZZLE`, `CLUES`, `TRIGGERS`, `LIGHTS`, then add each primitive (GameObject → 3D Object → Cube/Cylinder), set Transform values from the table, assign materials, mark `ENV/*` Static. Tips:

- Duplicate-and-edit is fastest: make one wall, then duplicate and retype position/scale from the table.
- Keep default colliders on everything; do **not** set walls/floors to trigger.
- Add the point lights from **manifest §5**; disable `L_Reveal_1`/`L_Reveal_2` (checkbox off — the reveal enables the GameObjects).

## 3. Input + data assets (4 min)

1. `Assets/Input/PurpleRain.inputactions` already exists on this branch — select it and verify the `Player` map shows Move / Look / Jump / Sprint / Crouch / Interact / ToggleJournal. (No "Generate C# Class" needed — the code loads actions from the asset at runtime.)
2. Create folders `Assets/Data/Channels`, `Assets/Data/Beats`, `Assets/Data/Evidence`.
3. Create the 7 ScriptableObject assets from **manifest §8** via `Assets → Create → Purple Rain → …` (Story Beat Channel ×1, Story Beat ×3, Evidence Item ×3) and fill their fields.

## 4. Player rig (4 min)

Build this hierarchy at the `PlayerSpawn` position `(0, 0, -22)`:

```
Player                      ← Tag: Player
├─ CameraPivot              ← empty, local position (0, 1.65, 0)
│  └─ Main Camera           ← move the scene's Main Camera here; local pos/rot zeroed
```

On `Player` add, in this order:

1. **Character Controller** — Height 1.8, Radius 0.35, Center (0, 0.9, 0), Step Offset 0.3.
2. **InputActionsProvider** — Actions Asset = `PurpleRain.inputactions`, Action Map Name `Player`.
3. **PlayerController** — Input = the provider (same GameObject), Camera Pivot = `CameraPivot`. Leave tuning defaults.
4. **Interactor** — Input = provider, Ray Origin = `CameraPivot`, Range 3, Layers = Everything.

Delete any other camera/AudioListener duplicates (one AudioListener, on Main Camera).

> **Cinemachine (optional, recommended once the slice runs):** add a **CinemachineBrain** to Main Camera (un-parent it from the pivot), create `GameObject → Cinemachine → Cinemachine Camera`, set **Tracking Target = CameraPivot**, and give it **Hard Lock to Target** (Position Control) + **Rotate With Follow Target** (Rotation Control). `PlayerController` only rotates the pivot, so either wiring works — for the 30-minute build, direct parenting is fine.

## 5. Systems + UI (5 min)

1. Create empty `SYSTEMS` → add **EvidenceJournal** (no fields).
2. Create `GameObject → UI → Canvas` (Screen Space Overlay; a default EventSystem appears — with the new Input System Unity uses `InputSystemUIInputModule`; accept the prompt if it offers to replace the module). Build:

```
Canvas
├─ PromptRoot        ← empty RectTransform, anchored bottom-center, pos (0, 120), size (600, 40)
│  └─ PromptText     ← UI → Legacy → Text; stretch to parent; centered; size 20; white
├─ MessageRoot       ← anchored top-center, pos (0, -80), size (900, 80)
│  └─ MessageText    ← Legacy Text; stretch; centered; size 18; color #E8DCC8
├─ FeedStatusRoot    ← anchored bottom-left, pos (24, 24), size (420, 30)
│  └─ FeedStatusText ← Legacy Text; stretch; left-aligned; size 16; color #9FB4B8
└─ JournalPanel      ← UI → Image; anchored right-stretch, width 420; color (0,0,0,0.75)
   ├─ Header         ← Legacy Text "FIELD NOTEBOOK #42 — debug view"; top of panel; size 16; bold
   └─ Content        ← empty RectTransform below header; add Vertical Layout Group
                       (padding 12, spacing 8, child force expand width ✔ / height ✗)
                       + Content Size Fitter (vertical: preferred)
```

3. On `Canvas` add the four UI scripts:
   - **InteractionPromptUI** — Interactor = Player's Interactor, Prompt Root = `PromptRoot`, Prompt Text = `PromptText`.
   - **HudMessageUI** — Message Root = `MessageRoot`, Message Text = `MessageText`, Duration 4. (Messages queue: a bark and a beat fired the same frame display one after the other.)
   - **WaterFeedStatusUI** — Status Text = `FeedStatusText` (wired to the puzzle in §6 step 2).
   - **EvidenceJournalUI** — Input = Player's provider, Panel Root = `JournalPanel`, Content Parent = `Content`, Entry Template = *(leave empty — entries are created at runtime)*.
4. On `SYSTEMS` add **StoryBeatListener** — Channel = `SBC-Main`, Filter Beat = *(empty)*, `onBeatText` → **+** → drag `Canvas` → **HudMessageUI → Show (string)** *(pick the "dynamic string" entry at the top of the function list so the beat text is passed through)*.

## 6. Puzzle wiring (5 min)

1. Add **ValveInteractable** to the four valve **roots** per **manifest §3** (name, starting Is Open state, Handle = the `Handle` child). Verb is forced to Use by the script; Display Name comes from Valve Name + live state.
2. On `PUZZLE/WaterFeedPuzzle` add **WaterFeedPuzzle** — 4 requirements exactly as manifest §3/§7 (fouled ✗ / bypass ✔ / main ✔ / drain ✗), Beat Channel `SBC-Main`, Solved Beat `BEAT-A2S03-FEED-RESTORED`. Wire `onProgressChanged (Int32, Int32)` → **+** → drag `Canvas` → **WaterFeedStatusUI → ShowProgress** *(pick the dynamic "int, int" entry)* — this is the puzzle's "wrong routing shows immediately" feedback.
3. On `PUZZLE/LeachateWallReveal` add **LeachateWallReveal** — Puzzle = `WaterFeedPuzzle`; Enable On Reveal = the two reveal lights; Disable On Reveal = `FlowGrate`; Unlock On Reveal = `Pickup_LeachateSample`'s EvidencePickup; Lock Targets On Start ✔.
4. Add the **ExaminePoint**s (`Examine_SedimentFan`, `Examine_DatumLine`, `Examine_PressureGauge`, and one on `FlowGrate`) with texts/evidence from manifest §3–4. For each, wire `onExamined (string)` → `Canvas` → **HudMessageUI → Show (string)** *(dynamic string)*.
5. Add **EvidencePickup** to `Pickup_LeachateSample` (Item `EV-A2S03-SAMPLE`, beat fields per manifest) and wire `onCollectedMessage (string)` → HudMessageUI.Show *(dynamic)*.
6. Add **TriggerVolume** to the three `TRIGGERS/*` cubes (Box Collider **Is Trigger ✔**, MeshRenderer **off**): wire each `onEntered` → HudMessageUI → **Show (string)** — this binding is *static*, so type the bark text from manifest §5 into the string field. `TV_WallApproach` also gets Beat Channel `SBC-Main` + Beat `BEAT-A2S03-WALL-SEEN`.

## 7. Test checklist (3 min)

Enter Play mode and verify, in order:

- [ ] Mouse look + WASD; Shift sprints (forward only); C/Ctrl crouches (camera dips smoothly; duck under the landing's low soffit — manifest §2 `CrouchSoffit` — and standing stays blocked until you back out); Space jumps.
- [ ] Nine's proposition line appears at the landing (once).
- [ ] Hovering a valve shows `[E] Use: West Intake — Upper Gallery — OPEN`; E toggles it and the wheel spins about its axle.
- [ ] Toggling any valve updates the junction-balance readout (`Junction balance: N/4 legs reading right`) — wrong states report, they never fail.
- [ ] The three examine points print their read and (two of them) add journal entries; Tab/J toggles the journal list.
- [ ] The grate examine explains the gate. Setting fouled=CLOSED, bypass=OPEN, main=OPEN, drain=CLOSED (any order) logs `[StoryBeat] BEAT-A2S03-FEED-RESTORED`, shows it on the HUD, opens the grate, and the reveal chamber glows violet down the gallery.
- [ ] The wall-approach line fires (the `BEAT-A2S03-WALL-SEEN` HUD line queues up right after it); the sample vial is now interactable (`[E] Take: Violet leachate sample`); taking it logs the sample beat and the journal shows 3 entries with `[Sample · BelowSourced]` on the vial.

## 8. Known editor-side gaps

- The graybox NPC "Nine" is text-only (trigger barks); a capsule + look-at is a 5-minute optional extra.
- No audio, no Waterline water plane, no crouch-forcing geometry on the critical path (the landing's `CrouchSoffit` is a headroom test, not level design) — all out of slice scope (see [SLICE_EVALUATION.md](SLICE_EVALUATION.md)).
- If `Physics.Raycast` prompts never appear, check the Interactor's Ray Origin is the **CameraPivot** and that valve colliders aren't set to trigger.
- If input is dead, check Project Settings → Player → Active Input Handling = **Input System Package (New)** — it already is on main — and that the provider's asset field is assigned.
