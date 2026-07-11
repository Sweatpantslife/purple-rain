# Vertical Slice — Evaluation & Next-Systems Recommendation

> Companion to [VERTICAL_SLICE.md](VERTICAL_SLICE.md) (assembly) and [GRAYBOX_A2S03_MANIFEST.md](GRAYBOX_A2S03_MANIFEST.md) (blockout data).
> Written against the canon in `docs/gameplay/GAMEPLAY.md`; system names in bold Title Case are canonical.

## 1. What is built (code on this branch)

**Scene/puzzle chosen:** **A2-S03 "The Name Trade"** with **P-A2-S03-1** (Hydraulic Routing, first full-depth instance). Rationale: it is the earliest scene that runs the complete INVESTIGATE → INFER → ACT → CONSEQUENCE loop in one self-contained space — read the water (sediment fan, datum line, dead gauge) → work the valve network (contamination isolation, order-free, no fail states per canon) → the reveal (the leachate wall re-lit, **R0 begins**, **C-02 payoff #1**, the sample logged in #42). It exercises every foundation system at once (movement, interaction verbs, evidence journal, story beats) and its grammar is the one the whole game examines again at A4-S06 — highest reuse per line of code.

| Area | Files (under `Assets/Scripts/`) | Status |
|---|---|---|
| Assembly def | `PurpleRain.Runtime.asmdef` | refs Unity.InputSystem, Unity.Cinemachine, UnityEngine.UI |
| Core | `Core/InputActionsProvider.cs`, `Core/StoryBeat.cs`, `Core/StoryBeatChannel.cs`, `Core/StoryBeatListener.cs`, `Core/TriggerVolume.cs` | input access without codegen; SO event channel for story beats; generic trigger |
| Player | `Player/PlayerController.cs` | FPS controller: walk/sprint/crouch (smoothed + headroom check)/jump/gravity; pitch on CameraPivot, yaw on body — Cinemachine 3.x-ready, zero Cinemachine API at runtime |
| Interaction | `Interaction/InteractionVerb.cs`, `IInteractable.cs`, `Interactor.cs`, `InteractableBase.cs`, `ExaminePoint.cs` | raycast interactor with hover/focus C# events + UnityEvent prompt hooks; Examine/PickUp/Use verbs; lockable interactables |
| Evidence | `Evidence/EvidenceItem.cs`, `EvidenceJournal.cs`, `EvidencePickup.cs` | SO clue defs with **provenance** (surface/below/unsourced — guardrail §8.4 honored from day one); MonoBehaviour-singleton journal service with C# events |
| UI | `UI/InteractionPromptUI.cs`, `UI/HudMessageUI.cs`, `UI/EvidenceJournalUI.cs` | uGUI debug HUD: hover prompt, one-line message sink, ToggleJournal list |
| Slice | `Puzzles/ValveInteractable.cs`, `Puzzles/WaterFeedPuzzle.cs`, `Puzzles/LeachateWallReveal.cs` | state-based order-free valve network; latched solve → beat + reveal sequencing |
| Input asset | `Assets/Input/PurpleRain.inputactions` | hand-authored JSON, `Player` map: Move/Look/Jump/Sprint/Crouch/Interact/ToggleJournal, KB+M scheme |
| Docs | `docs/dev/GRAYBOX_A2S03_MANIFEST.md`, `docs/dev/VERTICAL_SLICE.md`, this file | full blockout tables + ~30-min assembly guide |

## 2. What needs the editor (cannot be authored headlessly)

- **Scene assembly** — `A2S03_NameTrade_Graybox.unity` per the manifest (~30 min). Hand-writing scene YAML would require fabricating asset GUIDs; deliberately not done.
- **`.meta` generation** — this repo commits metas; Unity must mint GUIDs for all new files on first open, then commit them.
- **ScriptableObject assets** — 7 assets (channel, 3 beats, 3 evidence items); same GUID reason.
- **Materials, lighting, UI layout** — graybox mats, ambient, Canvas hierarchy per the guide.
- **Cinemachine rig** — optional CinemachineCamera + Brain wiring (documented); runtime code has no Cinemachine dependency by design.
- **Play-test pass** — tuning feel numbers (speeds, sensitivity, interaction range) are untested defaults.

## 3. Risks

| Risk | Likelihood | Mitigation |
|---|---|---|
| Compile drift: hand-written code was never compiled here | medium | code sticks to long-stable APIs (CharacterController, Physics, uGUI, InputAction polling); self-review pass done; fix-forward on first editor open is expected to be minutes, not hours |
| `.inputactions` schema rejection | low | JSON mirrors the Unity 6 template asset in this repo field-for-field (same schema, fresh GUIDs) |
| asmdef reference names (`Unity.InputSystem`, `Unity.Cinemachine`, `UnityEngine.UI`) | low | names match the assemblies shipped in the pinned package versions in `Packages/manifest.json` |
| Legacy `Text`/`LegacyRuntime.ttf` deprecation path | low | uGUI 2.0.0 still ships both; if the project later standardizes on TMP, swap the three UI scripts' `Text` fields — they are isolated in `PurpleRain.UI` |
| Trigger volumes vs CharacterController | low | CharacterController generates trigger contacts; player must keep the `Player` tag (documented in the guide) |
| Canon risk: slice invents Nine barks as HUD text | accepted | placeholder strings, clearly non-canon phrasing kept minimal; real dialogue is Phase 3 writing |

## 4. Recommended next systems (grounded in GAMEPLAY.md)

Recommended order: **1) Interaction/UI hardening → 2) Stealth + Heat → 3) Dialogue (Riddle Exchange register) → 4) Save/load.**

1. **Field Notebook proper + Evidence Board data model** (extends what's here). The journal stub already carries provenance; promote it to the diegetic **Field Notebook** (auto-jot on examine, flagging) and give evidence *source metadata* (where/when/through whom — §2.3 doctrine, and the honest mission-giver metadata that §3.3's fair-play interlock requires later). Cheap now, structural later; everything in Acts 0–IV reads or writes this.
2. **Stealth (Light/Sound/Sightline) + Heat.** Curriculum order is load-bearing (§4.3, §8.7): A2-S02's depot tutorial precedes A2-S03 in play order, and **Heat** onlines at A2-S02 (scripted floor move #1, §3.2). Building stealth second means the two scenes adjacent to the slice become playable next, giving a contiguous A2-S01→S04 chunk. Heat's data shape (per-district floor + player band, two faces) should be stubbed with the same channel/SO pattern as story beats.
3. **Dialogue** — start with **Riddle Exchange register 1** (the Lantern door, A1-S09) and trigger-bark replacement for Nine in this slice; **Leverage** (§2.4.1) can wait until the Case File exists. Dialogue earlier than save/load because three of the slice's neighbors (A2-S01, A2-S04, A2-S05) are dialogue-weighted.
4. **Save/load.** The failure doctrine (§2 preamble) checkpoints at *phase boundaries*, so serialization needs: journal contents, story-beat flags, puzzle latch states, valve states, Heat floor/band, and the four valve-choice flags (`valve.*`, §3.4) — all of which are already (or should be kept) plain serializable state behind services. Doing it fourth means three systems' state shapes are known instead of guessed.

Anti-recommendation: do **not** build Waterline, boats, or the Camera yet — they are Act II texture that A2-S03's graybox only gestures at, and each depends on stealth/sound layers (§2.2) landing first.
