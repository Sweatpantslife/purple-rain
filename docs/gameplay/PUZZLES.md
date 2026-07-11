# PURPLE RAIN — Puzzle & Riddle Compendium (v1.0)

> **Phase 2 puzzle design.** Every puzzle, riddle, and solve-obstacle in *Purple Rain*, mapped to its scene. Derived exclusively from the canon, in priority order: [`../narrative/STORY.md`](../narrative/STORY.md), [`../narrative/MYSTERY_LOGIC.md`](../narrative/MYSTERY_LOGIC.md), [`../narrative/TIMELINE.md`](../narrative/TIMELINE.md), then [`../storyboard/SCENES.md`](../storyboard/SCENES.md), [`../storyboard/CHARACTERS.md`](../storyboard/CHARACTERS.md), [`../storyboard/LOCATIONS.md`](../storyboard/LOCATIONS.md) — and the system canon in [`GAMEPLAY.md`](GAMEPLAY.md) (mechanics, taxonomy §7, guardrails §8). Any conflict resolves in favor of the narrative docs, then the storyboard, then GAMEPLAY.md, then this document.
>
> **Spoiler policy:** total spoilers. Playtesters and blind contractors should not read this document.

## Legend & conventions

- **Puzzle IDs:** `P-<scene>-<n>` (e.g. `P-A2-S07-1`), keyed to the canonical scene ID where the puzzle lives. Scene (`A0-S01`…`A4-S11`), character (`CH-*`), location (`LOC-*`), clue (`C-01`…`C-35`), red-herring (`RH-01`…`08`), and reveal (`R0`–`R5`) IDs are canonical and used verbatim.
- **Two entry classes** (declared per entry under **Type**):
  1. **Taxonomy puzzles** — tagged with exactly one type from GAMEPLAY.md §7's canonical taxonomy: **Hydraulic Routing**, **Tracer Logic**, **Vestry Cipher**, **Riddle Exchange**, **Document Forensics**, **Correlation**, **Scene Reading**, **Composite Gauntlet**. No new types are introduced by this document.
  2. **System obstacles** — solve-shaped mission obstacles (locks, hacks, forgeries, stealth gauntlets, interrogations, flood traversals) that run on GAMEPLAY.md §2's mechanics (**Stealth (Light/Sound/Sightline)**, **Waterline**, **Lockpicking**, **Systems Work**, **Forgery**, **Social Engineering**, **Leverage**, **Confrontation**, **Camera**). These are *not* taxonomy puzzles and do not extend the taxonomy; they are listed because the player must solve them, and the task of this document is complete coverage.
- **Fail-state doctrine (global, from GAMEPLAY.md §2/§7):** puzzles never hard-fail — cost is time, **Heat**, or tension; soft-fail forward is the default; hard fail (reload) exists only for combat death and blown terminal-stealth states, checkpointed at phase boundaries. Hints restate *reading rules*, never answers (§2.4.2 hint doctrine). Accessibility tiers may soften timers and detection, never puzzle logic.
- **Fair-play doctrine (global, from MYSTERY_LOGIC.md §0/§6):** every solution below cites what the player has already been shown. No puzzle asks for knowledge that the critical path has not planted. Puzzles must *reveal* story — every entry states the clue or reveal it unlocks. A puzzle that pads time is a defect.
- **Curriculum (GAMEPLAY.md §4.3, binding):** depot panel literacy (A2-S02) before the archive annex (A2-S07); A2-S03 valve grammar before A4-S06; cipher lessons (A2-S10, A3-S06) before the crypt (A4-S02); the clinic emblem (A3-S09) before the chalk signal (A3-S15). **No new puzzle grammar after Act III** — Act IV recombines only.

---

## 1. Coverage table — every scene, act by act

Proof of coverage: all 58 scenes accounted for. A scene with no entry states why it carries none (cutscene, authored dialogue, traversal setpiece, or plant-only investigation texture). "Standing" = a puzzle that opens at the anchor scene and stays live across acts.

| Scene | Title | Puzzle / obstacle entries | If none — why (and what investigation content it carries) |
|---|---|---|---|
| **Act 0** ||||
| A0-S01 | "Anniversary Morning" | — | Tutorial interactions (movement, examine, **Field Notebook** habit); no solve. C-01 planted in dialogue |
| A0-S02 | "The City in the Rain" | — | Traversal; optional examine/journal of the graffiti (C-02 plant); folktale NPC optional. No solve |
| A0-S03 | "The Waterworks" | **P-A0-S03-1** | Also: C-03 memo is a Case File read (no solve); C-28 brushed in smalltalk |
| A0-S04 | "The File" | **P-A0-S04-1** | — |
| A0-S05 | "Chess with Ray" | — | Light chess-move interaction + dialogue; C-05/C-06 plants. Authored, no solve |
| A0-S06 | "Theo" | **P-A0-S06-1** *(optional)* | — |
| A0-S07 | "The Anniversary" | — | Cutscene. C-33 and C-08 are attentional plants only (staged so only attentive players clock C-08) |
| A0-S08 | "Purple Dawn" | — | Constrained interaction by design (look, comply, read — not resist). C-09 on-screen beat; C-10 warrant glimpsed, re-readable in the Act I **Case File**. No solve |
| **Act I** ||||
| A1-S01 | "Intake" | **P-A1-S01-1** | — |
| A1-S02 | "The Offer" | — | Dialogue probe; refusal is the authored exit. C-13 in dialogue. No solve |
| A1-S03 | "Anonymous Grace" | — | First-person scrum traversal; bail paperwork examine plants C-12 (**Case File** read, no solve) |
| A1-S04 | "House of Glass" | — | Errands-as-drama; the ledger (C-27 carrier) enters the **Case File** here — its anachronism is a standing optional find from Act II, homed at **P-A4-S01-1** |
| A1-S05 | "Everything, In Order" | — | Cutscene. RH-03 planted; the backwards-E signature is on screen "for one honest second" (attentional plant) |
| A1-S06 | "Theo's Silence" | **P-A1-S06-1** *(optional)* | — |
| A1-S07 | "The Second Wave" | — | C-14 corpus begins (read the tip); packing deliberation is playable choice, not a solve; RH-08 planted on TV |
| A1-S08 | "The Run" | — | Evasion setpiece (gauntlet, fail-forward, checkpoints per leg); scripted near-drowning. No puzzle |
| A1-S09 | "Below" | **P-A1-S09-1** | Also: Kray toll-story dialogue (shapes admissions, no solve) |
| **Act II** ||||
| A2-S01 | "The Rules of Below" | — | Hub orientation; **Favor Board** opens; brand-scar examine plants RH-04. No solve |
| A2-S02 | "First Job — The Pharmacy Run" | **P-A2-S02-1**, **P-A2-S02-2** | — |
| A2-S03 | "The Name Trade" | **P-A2-S03-1** | — |
| A2-S04 | "The Ferrywoman's Price" | — | Barter/dialogue over Kray's map (**Passage** negotiation); C-15 planted; the blank quarter shown. No solve |
| A2-S05 | "Iris" | **P-A2-S05-1** | — |
| A2-S06 | "Rook's Second Gift" | — | Cutscene/planning montage; board examinable; RH-02 texture in the papers. No solve |
| A2-S07 | "The Archive Heist" | **P-A2-S07-1**, **P-A2-S07-2** *(optional)* | Boat-chase exfil is a scripted-survivable setpiece (fail-forward) |
| A2-S08 | "Reading the Water" | **P-A2-S08-1**, **P-A2-S08-2** | — |
| A2-S09 | "Heat" | **P-A2-S09-1** *(standing, opens here)* | Scene body is cutscene; the journal gains the correlation data afterward |
| A2-S10 | "The Vestry Surfaces" | **P-A2-S10-1** | Also: the Verger's confession (dialogue); RH-02 and RH-04 debunked in-scene |
| A2-S11 | "Nightingale" | **P-A2-S11-1** | — |
| A2-S12 | "What They Say I Am" | — | Cutscene. Kill-team era begins; bounty below; RH-08 murder authored onto Adam. No solve |
| A2-S13 | "The Choice in the Dark" | **P-A2-S13-1** | Commitment beat (tracked valve) is a choice, not a solve; C-07 payoff #2 in confession |
| A2-S14 | "Act Turn — Out of Hell" | **P-A2-S14-1** *(standing, optional)* | Scene body is cutscene (the mailing is authored); board examinable before it |
| **Act III** ||||
| A3-S01 | "The Ascent Plan" | — | War-room cutscene; board examinable; C-25 pinned mid-board unremarked. No solve |
| A3-S02 | "Whitlock Bites" | — | Interleaved perspective, witnessed (Adam is player-locked). C-18 verified, C-12→Aegis, C-08 legible. No solve |
| A3-S03 | "The Trust Job" | **P-A3-S03-1**, **P-A3-S03-2** | Kessler encounter is authored dialogue (she never lies; nothing convictable — by design) |
| A3-S04 | "The Meaning of Money" | — | Cutscene: Duval's decode lands **R2**; decoded documents join the examinable board. No solve |
| A3-S05 | "Voss's Summons" | **P-A3-S05-1** | Scene body cutscene + brief garden-escape sting; C-23, C-32 planted; RH-05 collapsing |
| A3-S06 | "The Window" | **P-A3-S06-1** | — |
| A3-S07 | "Duval's Gun Jumps" | — | Cutscene (THE REVERSAL). C-25 detonates — the payoff of the player's own audit failure (see P-A2-S14-1); C-30 planted in the wreckage |
| A3-S08 | "Theo" | **P-A3-S08-1** *(authored, no input)* | Interactivity deliberately withheld; listed because it is a canonical Scene Reading instance |
| A3-S09 | "The Funeral" | — | Cutscene. **Curriculum beat:** teaches the clinic-emblem signal (Mara's pin on the headstone) that P-A3-S15-1 assumes. Do not cut |
| A3-S10 | "Rage" | **P-A3-S10-1** | Valve choice (kill/flip/walk) is tracked, not scored; evidence outcome path-independent |
| A3-S11 | "The Rat" | **P-A3-S11-1** | — |
| A3-S12 | "Canary Trap" | **P-A3-S12-1**, **P-A3-S12-2** | — |
| A3-S13 | "One Last Game" | **P-A3-S13-1** | — |
| A3-S14 | "Lena" | — | Cutscene. The watch-fob key (C-23) opens the strongbox as an authored beat; letters join the board; C-30 payoff. No solve |
| A3-S15 | "Mara's Ledger" | **P-A3-S15-1** *(trigger)* | Scene body is cutscene (C-01 payoff; RH-03 fully debunked); the player's solve is the trigger that opens it |
| A3-S16 | "The Plan" | — | Mixed planning (role assignment); **binding rule:** the plan must visibly cite the player's A2-S11 recon (photographs, maintenance log) — knowledge-as-ability, not a solve |
| **Act IV** ||||
| A4-S01 | "Nine Days" | **P-A4-S01-1**, **P-A4-S01-2**, **P-A4-S01-3** | The Sampler (Whitlock→AG→Chen) and the Ledger (Concordance surfaced) threads are witnessed authored prep beats — Adam is player-locked (GAMEPLAY.md §8.2) and neither thread contains an Adam action; reconciled with SCENES.md A4-S01 (five threads: three playable, two witnessed) |
| A4-S02 | "The Concordance" | **P-A4-S02-1** | R4 document examination at the reading ledge is authored (reveals land on players at rest) |
| A4-S03 | "Marr's File" | — | Cutscene; the vault extraction stays off-screen (binding). R5 armed. No solve |
| A4-S04 | "Eve of Vesper" | — | Cutscene. No solve |
| A4-S05 | "Ratification Day" | **P-A4-S05-1** | Deployment cross-cut is authored; credentials scan is the payoff of P-A4-S01-3 |
| A4-S06 | "The Nightingale Falls" | **P-A4-S06-1**, **P-A4-S06-2** *(optional branch)* | Marr valve (walk/fight) is tracked; canonical = he walks |
| A4-S07 | "Purple Rain" | — | Cutscene (THE SCENE). Tracer Logic's *narrative payoff*: TS-19/44 re-validated against live chemistry — the player's difficulty was already spent authoring it at A4-S06 |
| A4-S08 | "The Undercroft Door" | — | Zero mechanical difficulty by fiat: no combat verbs load at LOC-seal-chamber; the hardest input is the valve choice (drown/abandon/save, identical blocking; save path = effortful assisted-climb inputs, not a puzzle) |
| A4-S09 | "Fallout" | — | Documentary montage. Correlation's *narrative payoff*: the provenance lattice as prosecution exhibit list. No solve |
| A4-S10 | "What Heaven Is Now" | — | Epilogue; one slow playable walk; no fail states. No solve |
| A4-S11 | Post-credit sting | — | Camera-only cutscene; optional; no traversal verbs. No solve |

**Tally:** 37 entries — 23 taxonomy puzzles, 12 system obstacles, 2 hybrid (taxonomy puzzle wrapped in a system obstacle: P-A2-S11-1, P-A3-S03-2 declare both). Every scene whose SCENES.md Player objective is "Mixed" or names a puzzle, solve, or investigation interaction either owns an entry or is explained above. No puzzle-bearing scene is orphaned.

---

## 2. Act 0 — Grace

### P-A0-S03-1 — "The Sector 9 Anomaly"
- **Scene / Location:** A0-S03, LOC-waterworks (flow-map floor).
- **Type:** Hydraulic Routing (tutorial instance; also the debut of **Tracer Logic** literacy and **Water Reading**'s vocabulary).
- **Mandatory.**
- **Setup:** A live low-pressure anomaly in Sector 9 lands on Adam's desk — his day job, played as the competence tutorial. The flow-map interface shows the district's mains, junction pressures, and flow directions.
- **Solution:** Read the flow map like Adam reads water: follow the pressure gradient upstream of the complaint cluster, identify the junction whose downstream legs disagree with its upstream supply, and isolate the faulted leg (the interface confirms with a re-balanced map). The puzzle is fully guided — colleagues' dialogue names each reading rule as the player applies it. **Fair because:** it teaches; it assumes nothing. This is the grammar lesson the entire game's hydraulics family (A2-S03, A4-S06) is built on, introduced as a day job.
- **Clues:** None carried — this is curriculum, not mystery. (The same scene plants C-03 in the inbox and brushes C-28 in smalltalk, both as reads, not solves.)
- **Fail states:** None. Wrong valve choices re-balance visibly and invite another read; no timer, no consequence. Act 0 has no fail states by canon.
- **What it advances:** Establishes *reading water* as Adam's superpower and the player's core literacy (knowledge-as-ability table, GAMEPLAY.md §4.3: "the puzzle grammar of the whole game"). Story: establishes Adam's standing and the P.E. stamp — the object the plot orbits — and hands off to A0-S04 via the C-03 memo.

### P-A0-S04-1 — "Figure 12"
- **Scene / Location:** A0-S04, LOC-waterworks (records terminal).
- **Type:** Document Forensics (debut of the discrepancy-spot mechanic).
- **Mandatory** (soft-gated).
- **Setup:** The CLEARWATER memo (C-03) sends Adam to confirm archival integrity of his old filings. He pulls TS-19/44 — and Figure 12 in the archived copy doesn't match his memory. He fetches field notebook #29.
- **Solution:** Two-up **compare** of archived Fig. 12 against notebook #29's field curve, then **spot** the discrepancy: the archived curve is cleaner, sensor-error-shaped, someone else's math. The player clicks the divergence; the evidence card names the specific contradiction. **Fair because:** the two curves are on screen side by side and the difference is visually honest; the mechanic's verbs (compare/spot) are introduced here with exactly one discrepancy to find.
- **Clues:** Plants **C-04** (the doctored archive + the QA email). In retrospect it also exhibits C-06 (the forged math is the Cordell shortcut — payoff at A2-S08, not here).
- **Fail states:** None hard. Mandatory spot gates softly — Adam "can't shake it" until found; long idles trigger nudge lines. The true consequence is *solving it*: sending the QA email is the tripwire (T-2026b) that detonates Adam's life ten gameplay-hours later — the **Core Loop**'s first lesson that consequence is real.
- **What it advances:** Plants C-04; triggers the frame's "go" order (raid timing, Act I); feeds R1's assembly at A2-S08. The game's thesis in one interaction: diligence, weaponized against the diligent.

### P-A0-S06-1 — "What's Missing from the Drawer" *(optional)*
- **Scene / Location:** A0-S06, street outside the MWA + LOC-vale-rowhouse (evening).
- **Type:** Scene Reading (optional noticing — Act 0's only "difficulty" per GAMEPLAY.md §5).
- **Optional.**
- **Setup:** Theo intercepts Adam — too bright, too funny, new phone, asking for a loan. That evening, dressing for dinner, Adam's desk drawer is examinable.
- **Solution:** Observe the wrongness the scene never announces: betting slips in Theo's jacket, a second phone in his pocket; and at home, the spare MWA badge *absent* from the drawer. There is nothing to click "correct" — noticing and journaling is the whole verb. **Fair because:** it costs nothing to look; the game files what the player flags; nothing downstream requires having looked (the critical path re-plants everything).
- **Clues:** Plants **C-07** (the missing spare badge — the frame's physical-access vector) and **C-26** (Theo's needle-faint joke, delivered in dialogue whether or not the player examines anything).
- **Fail states:** None. Not noticing simply defers comprehension to the payoffs (A1-S05, A2-S13, A3-S08, A4-S09).
- **What it advances:** The fair-play texture of Theo's arc; players who caught C-07 experience A1-S05's badge-log accusation as a click of dread rather than confusion. NG+ reward density.

---

## 3. Act I — The Fall

### P-A1-S01-1 — "Count 31"
- **Scene / Location:** A1-S01, LOC-courthouse (booking & remand).
- **Type:** Document Forensics (document-reading tutorial on the **Case File**).
- **Mandatory.**
- **Setup:** The charges are read aloud — 46 counts. The charge sheet itself is the tutorial document: dense RICO thicket, magnifier verb, pin-to-board (later) verb.
- **Solution:** Read the sheet and find the anomaly buried in it: **Count 31 — falsification of hydrological field data, 2018–2020.** The solve is semantic, not visual: why would a *fraud* case care so precisely about field-data dates? The player magnifies, finds, and flags it. **Fair because:** the count is verbatim on the page; the oddity is available to plain reading from hour one (MYSTERY_LOGIC.md §6 requires it); Hale's "author" soundbite in the same scene primes the question.
- **Clues:** Plants **C-11** (the date window brackets TS-19/44 — and, unknown yet, Cordell's supervision window). RH-07 begins its build around Hale in the same scene.
- **Fail states:** None hard; the tutorial gates softly until Count 31 is found (the scene's exit is the document).
- **What it advances:** The first strand of R1 ("the frame targets the past"), formally assembled at A2-S08. Teaches the Case File doctrine: documents are complete and honest; a careful reader can beat the reveals.

### P-A1-S06-1 — "The Taps Running" *(optional)*
- **Scene / Location:** A1-S06, LOC-betting-cafe.
- **Type:** Scene Reading (optional).
- **Optional.**
- **Setup:** Adam confronts Theo about the badge night. Theo lies badly, over-laughs, presses cash on him, and cries in the bathroom with the taps running. The café is searchable while the scene breathes.
- **Solution:** Find the two player-findable wrongnesses: fresh betting slips *paid off* (a broke gambler suddenly square) and a burner phone with exactly one saved number. Journal them. Adam cannot make himself see what they mean; the player can — the gap between player and character *is* the scene. **Fair because:** the objects are in the open, the paid-off slips contradict everything Act 0 established about Theo, and nothing requires the inference to proceed.
- **Clues:** Deepens the C-07 chain (who borrowed the badge, and for whom) and Theo's behavioral-collapse texture running since A0-S06. No new clue ID — this is corroboration, per MYSTERY_LOGIC.md rule 3 (optional content deepens, never exclusively plants).
- **Fail states:** None.
- **What it advances:** Dramatic irony as level design; primes A2-S13's confession so it lands as confirmation, not exposition.

### P-A1-S09-1 — "The Lantern Door"
- **Scene / Location:** A1-S09, LOC-lantern (riddle door, causeway plank).
- **Type:** Riddle Exchange (register 1: the door — "a filter for cops and fools").
- **Mandatory.**
- **Setup:** Kray deposits the half-drowned fugitive at the Lantern's hatch. A voice through the door asks the first diegetic riddle — simple, teachable, the Verger's filter.
- **Solution:** Answer from lived experience — the door accepts **multiple answers drawn from anything the player noticed in Acts 0–I** (the rain, what was taken, what water does to paper — authored answer-set, all validating that the speaker has *lived* the city rather than studied it). Spoken riddles are diegetic conversation; no riddle-box minigame. **Fair because:** the answer space is deliberately wide and every accepted answer is something the game has already shown the player; the Verger is filtering intent, not IQ.
- **Clues:** None carried. (The scene's information — the three rules, the Verger's held gaze — is dialogue.)
- **Fail states:** Wrong answers get colder soup and a second try. No lockout. Later visits auto-resolve to a knock pattern — belonging, textured (the door riddle is a one-time solve that becomes hub texture).
- **What it advances:** Entry to the **Lantern Hub** — end of Act I, start of the favor economy. Introduces the Riddle Exchange family and the game's rule that riddles are people talking, which the Vestry's cipher culture will darken from A2-S10 on.

---

## 4. Act II — Hell

### P-A2-S02-1 — "The Pharmacy Run"
- **Scene / Location:** A2-S02, LOC-depot.
- **Type:** System obstacle — **Stealth (Light/Sound/Sightline)** tutorial + **Lockpicking** debut (GAMEPLAY.md §2.2, §2.5.1; not a taxonomy puzzle).
- **Mandatory.**
- **Setup:** The Lantern's insulin and antibiotics come from "shrinkage" at a medical distribution depot; this month's contact got caught, so Adam goes. Security contractor: Aegis Meridian — first sight of the logo.
- **Solution:** Full stealth-infiltration tutorial: read patrols, use sodium-light penumbra lanes, match footstep pace to the compressor's masking hum (the Sound lesson this location canonically teaches), **pick** the pharmacy cage lock (tension + feedback, quiet hands; picking under masking noise is genuinely easier — Lockpicking and Stealth share the Sound model), take the crate, exfiltrate. **Fair because:** every detection channel is introduced singly with its counter, and the level is tuned forgiving.
- **Clues:** RH-02 texture (liftable freight paperwork referencing Pier District redevelopment — the "wrong building" misdirection begins accumulating in the hauls).
- **Fail states:** Detection tunes to **chase-out, not reload** ("the tutorial teaches consequence, not punishment" — LOCATIONS.md); broken picks are consumable friction; **Heat** onlines at this scene (first crime; scripted floor moves here per GAMEPLAY.md §8.8).
- **What it advances:** The moral note that scores the act — hell's crimes feed people, and Adam is *good* at this. Tool acquisition: lockpicks. Curriculum: the stealth grammar every later infiltration assumes.

### P-A2-S02-2 — "Reading the Panel" *(curriculum beat — do not cut)*
- **Scene / Location:** A2-S02, LOC-depot (alarm panel by the dock man-door).
- **Type:** System obstacle — **Systems Work**, read-panels verb (GAMEPLAY.md §2.5.2).
- **Mandatory on the critical route through the depot.**
- **Setup:** A readable alarm panel sits by the dock man-door, armed zones legible, zone map printed on a card beside it — as in real buildings.
- **Solution:** Read the panel: which zones are armed, which door is on which zone, and route the exfiltration accordingly (or re-route power to douse a lit lane — a breaker is a valve). **Fair because:** the zone card is beside the panel and the UI is the panel itself; the lesson is that *panels can be read at all*.
- **Clues:** None here — but this literacy **is** the fair-play delivery mechanism for C-17's fourth oddity: A2-S07's exit-only alarm panel is legible *only* to players taught here. Canonical curriculum link (LOCATIONS.md; GAMEPLAY.md §4.3, §8.7).
- **Fail states:** Mis-reads trip what they were meant to disarm — alarm → escalation timer, mission continues under pressure.
- **What it advances:** Security-panel literacy, checked (not gated) at A2-S07 and every panel after. This is a teaching beat with a mystery payload two scenes downstream.

### P-A2-S03-1 — "The Name Trade" (the Undercroft feed)
- **Scene / Location:** A2-S03, LOC-undercroft (gravity-fed supply gallery, deep tunnels).
- **Type:** Hydraulic Routing (first full-depth instance: valve network + contamination isolation).
- **Mandatory.**
- **Setup:** Nine's price for a clean identity is competence: the Undercroft's gravity-fed water feed is fouling, and word is the new man reads water. The route to the junction deliberately passes the leachate wall.
- **Solution:** At the junction, use **Water Reading** (flow direction, sediment, stain history, datum lines) to identify the fouled branch, then work the valve network: close off the contaminated leg, re-route supply through the clean galleries, and re-pressurize the feed — contamination isolation, the exact professional grammar of A0-S03 at field scale. The final valve turn re-lights the chamber and reveals the wall staged like an altar: **violet leachate, live, sheeting down Works-era brick.** Then the **Tracer Kit**'s sample verb: old habit outlives the old life — take the sample, label it, log it in #42. **Fair because:** the grammar was taught at A0-S03; every junction carries legible flow/sediment cues; multiple valid valve orders reach the same isolation (no single-solution trap).
- **Clues:** **C-02 payoff #1** (the folklore is running in real time); the logged violet sample becomes the signature the **match** verb checks against for the rest of the game.
- **Fail states:** Wrong routing shows immediately as flow/pressure feedback and invites re-reads; no timer, no Heat (the Undercroft is not hostile space here). Inconclusive work costs time only.
- **What it advances:** **R0 begins** — the story's floor shifts: this was never just about him. Earns the clean identity (Nine's papers). Curriculum: valve grammar that A4-S06 formally assumes (binding, GAMEPLAY.md §8.7).

### P-A2-S05-1 — "Sixty Percent Noise"
- **Scene / Location:** A2-S05, LOC-duval-flat.
- **Type:** Scene Reading (interactive crazy-wall + recognition compare).
- **Mandatory (the connection); wall exploration free-form.**
- **Setup:** Duval's wall — interactive, examinable, 60% noise and 40% dead accurate. In the middle: the 2020 spiked story, a photo of Coby Anders, drowned, and a circled phrase: *"They don't kill stories. They kill authors."* Then she produces her surviving fragment of the 2020 leak: a data table.
- **Solution:** Two movements. (1) Read the wall — sort signal from noise by examining nodes; the game does not grade the sort, but Adam's voiced recognitions confirm the accurate 40% as the player touches it. (2) The turn: **compare** the fragment's data table against what Adam knows cold — his own numbers. The player (via notebook memory, staged as a guided compare) confirms: the leak that destroyed Duval came from TS-19/44. **Fair because:** the player has seen TS-19/44's data twice (A0-S04, and it is Adam's own study); the fragment is honestly reproduced; the wall's signal items all reference things the player has met or will verifiably meet.
- **Clues:** **C-16** (Anders' drowning; the method statement — the playbook's first run, correctly diagnosed).
- **Fail states:** None hard; the connection beat gates softly with Duval's dialogue converging on it.
- **What it advances:** The guilt bomb and the alliance; knowledge-as-ability: *the playbook's shape* (GAMEPLAY.md §4.3) — the player's only pre-armed defense against C-25 (they usually won't use it; that is the lesson). Feeds R1 support at A2-S08 and the pattern-recognition of A3-S07.

### P-A2-S07-1 — "Bay 9"
- **Scene / Location:** A2-S07, LOC-archive-annex.
- **Type:** System obstacle — **Stealth** infiltration + **Systems Work** (panel read, terminal/fiche retrieval); exfil is a scripted boat-chase setpiece.
- **Mandatory. MIDPOINT.**
- **Setup:** ROOK9's tip: purge order Friday — TS-19/44 original, microfiche, custody logs, the seized notebooks, all scheduled for the shredder. Night infiltration of the county records warehouse, Kray on water exfil, Nine on comms.
- **Solution:** Infiltrate via shelf-top verticality, retrieve the Bay 9 box (original TS-19/44 + raw data + custody fiche + the raid's seized field notebooks, #29 among them), exit to the loading dock, and escape by boat through the flooding channels. **Deliberately, bindingly easy** (GAMEPLAY.md §8.3): the skeleton crew is a mechanical fact, the box is pre-staged near the dock, and the escape is scripted-survivable — peak tension, low lethality. The player must leave feeling brilliant. **Do not "fix" this level in tuning passes: the tuning is C-17's trap.** **Fair because:** as a challenge it under-promises by design; the *real* puzzle in the scene is P-A2-S07-2.
- **Clues:** Carrier scene for C-17 (see next entry).
- **Fail states:** In-level stealth failures are recoverable (search → escalation); the exit alarm is *choreography* — it trips regardless and drives the authored boat chase, which is fail-forward with checkpoints. The victory itself is the deferred fail state: the heist manufactures the records-compromise order's cause (A2-S09) and taints the original's custody (A4-S02).
- **What it advances:** Physical possession of the original TS-19/44 — the input for A2-S08 and both of its solves. The music says first real victory; the music is lying.

### P-A2-S07-2 — "Too Clean" *(optional in the moment; retro-graded)*
- **Scene / Location:** A2-S07, LOC-archive-annex.
- **Type:** Scene Reading (the four oddities — readable-but-deniable).
- **Optional (flagging); the facts are re-presented at payoff regardless.**
- **Setup:** Everything goes almost suspiciously well. Four oddities are visible to a careful player and explicable to a trusting one.
- **Solution:** Notice and journal: (1) the roster board with too few names — a skeleton crew *on purge week*; (2) the Bay 9 box pre-staged in the forklift lane; (3) the evidence seal *already broken* (examinable insert); (4) the alarm panel armed on **exit only** — legible exclusively through P-A2-S02-2's literacy. Each oddity is individually explicable ("luck; good planning; sloppy archive"); flagging them is hypothesis work on the **Evidence Board** (wrong strings welcome — it is a hypothesis surface). **Fair because:** all four are diegetically present and honest; the panel read was taught; the game never lies about what is on screen — it relies on the player's gratitude to Rook to misread it (C-29's later ambiguity re-primes this audit instinct).
- **Clues:** **C-17** planted. Partial payoff A2-S09 (the compromise order lands); full payoff A4-S02 (the pre-drafted choreography memo, matched beat for beat against the player's own heist map).
- **Fail states:** None — not noticing *is* the intended majority experience; the A4-S02 re-grade is built to work on both audiences (surprise for trusters, confirmation for auditors).
- **What it advances:** The mystery's deepest fair-play play: the player's proudest win is the enemy's move, and the evidence was on screen the whole time.

### P-A2-S08-1 — "Four Documents, One Desk"
- **Scene / Location:** A2-S08, LOC-lantern (evidence-board corner).
- **Type:** Document Forensics (the four-way assembly — the mechanic at maturity).
- **Mandatory.**
- **Setup:** The haul goes straight onto the table: original TS-19/44 vs. the doctored archive copy vs. notebook #29 vs. the fresh violet tunnel sample — assembled by the player's own hands.
- **Solution:** Three finds at the comparison bench. (1) **Compare/spot:** the doctored Figure 12's fabricated math uses the **Cordell shortcut** — logged as "whoever forged this was MWA-trained; that's the shortcut Ray teaches" (the knife hidden in plain sight). (2) **Date-check:** the revision block's reviewer initials **H.G. — Harold Grady — dated fourteen months after Grady died**; the scene floats "so Grady's the forger?" for one beat (**RH-06**) and debunks it with his obituary in the same scene: the "suspect" is the *proof*. (3) **Match:** the tunnel sample's signature against TS-19/44's chemistry — the study was true. **Fair because:** the shortcut was established as mentor-lore at A0-S05 (C-06); the obituary is provided in-scene; the **date-check** verb is introduced here with exactly one anachronism to find (mirroring P-A0-S04-1's debut phrasing for compare/spot); nothing requires outside knowledge.
- **Clues:** **C-18** found (the dead man's initials — "the one thread a cop can pull without believing Adam"); **C-06 payoff #1**; RH-06 planted and debunked in one scene per the red-herring rules.
- **Fail states:** None hard; mandatory spots gate softly with nudges. 
- **What it advances:** The evidentiary core of everything: C-18 is mailed at A2-S14, verified at A3-S02, and vacates the record-poisoning at A4-S09. The C-06 note is the quiet first strand of R3.

### P-A2-S08-2 — "Framed to Unwrite Me"
- **Scene / Location:** A2-S08, LOC-lantern (Evidence Board debut).
- **Type:** Correlation (board assembly to a stated conclusion — **R1**).
- **Mandatory.**
- **Setup:** The **Evidence Board** debuts. On it: the allocution dates (C-11), the CLEARWATER re-validation memo (C-03), the doctored archive (C-04), and — pinned now — the too-convenient 2019 promotion (C-28).
- **Solution:** **Pin** and **string** the four cards until the geometry snaps: every strand points *backward* at TS-19/44's window. Conclusion, stated aloud over the board: **"They didn't frame me to blame me. They framed me to unwrite me."** (**R1**.) **Fair because:** MYSTERY_LOGIC.md §6 certifies R1 solvable from Act I with exactly these clues (C-03 + C-04 + C-11); the board scene is the game catching the player up at latest, never information from nowhere.
- **Clues:** Consumes C-03, C-04, C-11, C-28; pins C-28 with its true reading available ("bury the finding, elevate the finder").
- **Fail states:** None — the board never blocks the critical path: canonical connections assemble in the scripted board-scene whether or not the player pre-built them; players who did get a shortened scene and dialogue acknowledgment (GAMEPLAY.md §2.3.5).
- **What it advances:** **R1** — the reveal spine's row 5 (TIMELINE.md §4; never reorder). The question mutates from *why me* to *what did I sign* — which aims the whole midgame.

### P-A2-S09-1 — "The Shape of the Leak" *(standing puzzle, opens here)*
- **Scene / Location:** Anchor A2-S09, LOC-lantern; live on the **Evidence Board** through A3-S10/S11.
- **Type:** Correlation (the interception pattern — solvable from A2-S09 per MYSTERY_LOGIC.md §6).
- **Optional-early; guaranteed-late** (the canon delivers the conclusion at A3-S10→S11 regardless).
- **Setup:** An Aegis snatch squad hits a Lantern supply drop Adam was scheduled for — first hard proof a leak exists. The suspicion montage mis-aims at Duval and Kray (**RH-01**); underneath, the honest data accumulates: from this scene on, the journal carries **mission-giver metadata** (always honest — binding fair-play interlock), and the board's **correlate** view exists.
- **Solution:** Correlate interceptions against mission metadata: the near-misses touch **only Nine-brokered movements** — never Duval-only information, and (auditable, binding) never the player's own **Heat** band, because leak-driven interceptions are authored and tagged distinct from Heat-driven responses (GAMEPLAY.md §3.3, §8.5). Pattern events: A2-S09 (the drop), A2-S12 era, A3-S03 (Aegis too fast at the gala). **Fair because:** the data is complete, honest, and timestamped in the player's own journal; Heat gives the seductive wrong answer ("they're everywhere") and the metadata gives the right one.
- **Clues:** **C-21** (the pattern), reinforced by **C-15** (Kray's one free gift: "Rat swims close to the boat, engineer") and **C-20** (Nine's fortunes tick upward after each near-miss; he asks where Adam sleeps; he is never raided).
- **Fail states:** None; an unsolved pattern simply persists as fugitive paranoia until A3-S10's geotags make it undeniable. Wrong strings (RH-01 at Duval) stay on the board until the A3-S11 debunk corrects the player's own handwriting.
- **What it advances:** Identifies the mole (the fair-play audit says the mole is solvable *here*); loads the Leverage deck for P-A3-S11-1; feeds the sequencing constraint that Nine must fall before the canary trap can mean anything.

### P-A2-S10-1 — "The Hymn Board" (the Vestry Cipher debut)
- **Scene / Location:** A2-S10, LOC-st-albans (drowned nave, by boat).
- **Type:** Vestry Cipher (hymn-number key → dedication-plaque cipher). Taught through a Riddle Exchange lesson (register 2 — lessons cannot fail).
- **Mandatory.**
- **Setup:** After his confession, the Verger begins the education: *"the city is the ledger; learn to read it."* The nave holds two surfaces: the hymn board, numbers frozen since 1968, and the dedication-plaque wall. The boat is the cursor — reading angle matters; positioning the boat is part of the puzzle.
- **Solution:** Apply the taught reading rule — the Verger gives it as call-and-response over the real objects: **"the number is the hymn; the hymn is the page."** The frozen hymn-board numbers index the plaque's text (number → hymn → letter/line selection), and the extraction yields a 1974 covenant fragment and one word spelled letter by letter into Adam's notebook: **NIGHTINGALE**. **Fair because:** the rule is explicitly taught in the same scene before it is applied; the two surfaces are both legible from the boat; the lesson register is defined as unfailable teaching.
- **Clues:** Opens **C-19** (the Nightingale service — the name that aims A2-S11). Scene also debunks **RH-02** (the water permits never touch the Pier; every hydrological thread drains toward the Vats) and **RH-04** (the brand is a wound, not a membership) in dialogue.
- **Fail states:** None — lesson riddles cannot fail; misapplied readings get the rule restated (hint doctrine), never the answer.
- **What it advances:** The Vestry Cipher grammar (curriculum for A3-S06 and A4-S02 chambers 1–2); the word that turns the investigation toward the Vats; the discovery-map row 6 material (the Covenant, the Vestry's existence).

### P-A2-S11-1 — "Inside the Machine"
- **Scene / Location:** A2-S11, LOC-nightingale-hall (the pump hall & the Vats).
- **Type:** Hybrid — System obstacle (**Waterline** approach + the act's **Stealth** peak) wrapping a **Scene Reading** recon objective executed with the **Camera**.
- **Mandatory.**
- **Setup:** Kray won't ferry the last quarter-mile; Adam wades it chest-deep, torch in his teeth (Waterline: chest-deep = no sprint, arms committed, no tools out but the vial). Beyond the map's blank quarter: a cathedral-sized Victorian pump hall, *running*.
- **Solution:** Three movements. (1) **The wade:** read datum lines and flow to pick the survivable approach. (2) **The recon:** photograph the machinery, the violet slick in the sump, the fresh bootprints; **lift the maintenance log** from the duty-station clipboard — contractor of record, **Larkspur Facility Services**. Camera focus/exposure under tension: rushed shots come out unusable; the story photographs are re-attemptable in-scene. (3) **The hide:** when the night crew arrives, hide *inside the pump's service hatch* — workers are task-locked but carry radios; the threat is escalation, not eyesight. **Fair because:** every stealth channel was taught by A2-S02; the crew's attention model is readable in posture and task animation; the photographs' purpose is diegetic (evidence needs provenance, and prints carry develop-dates).
- **Clues:** **C-19** completed (the hall itself + the Larkspur name); the site is the physical corroboration of T-1917/T-1974.
- **Fail states:** Graded stealth (suspicion → search → escalation); discovery escalates to evasion pressure, not instant fail; blown photographs downgrade evidence quality (usable, not mailable) unless retaken.
- **What it advances:** **R0 completes** — the cover-up is a live operating utility with a maintenance schedule. **Flagship knowledge-unlock (binding):** this recon — the photographs, the log, the walked layout — is the *only* reason A4-S06 is plannable; the A3-S16/A4-S01 plan must visibly cite it (GAMEPLAY.md §8.9). The midpoint's terror becomes the endgame's competence.

### P-A2-S13-1 — "Out Through the Water"
- **Scene / Location:** A2-S13, LOC-undercroft (the meet site, low tunnels, floodwater rising).
- **Type:** System obstacle — **Waterline** escape setpiece (drag/carry under the no-harm-Theo envelope).
- **Mandatory.**
- **Setup:** Marr's trap springs — the meet brokered "from Theo" *is* Theo: wired, terrified, weeping, Aegis in the walls. Chaos in collapsing, flooding tunnels.
- **Solution:** Escape with Theo: read the rising water for the open route (Water Reading under duress), break pursuit with a floodgate (water as ally — the taught counterplay), and **drag/carry** Theo through the flooded dark — the combat system's verb doing violence's opposite. Theo's confession spills between breaths. **Fair because:** the route logic uses established Waterline literacy; the setpiece is checkpointed and fail-forward; the game supplies the floodgate affordance visibly.
- **Clues:** **C-07 payoff #2** — the badge, confessed: "I didn't know it was for *you*, Adam."
- **Fail states:** Soft — swept-back-and-retry within the setpiece; scripted survivability where fiction demands it. **Inviolable (binding): no mechanism exists to harm CH-theo** — no combat verbs resolve against him, ever.
- **What it advances:** The commitment beat (tracked valve `valve.commitment` — a choice, not a solve, logged here for completeness) and the confession that closes the badge question opened at A0-S06/A1-S05. The forgiveness that fires A3-S08.

### P-A2-S14-1 — "The Card Nobody Sourced" *(standing, optional — the provenance audit)*
- **Scene / Location:** Anchor A2-S14, LOC-lantern (the board wide-shot); live until A3-S07.
- **Type:** Document Forensics (authenticate-provenance verb on the **Evidence Board**'s audit view).
- **Optional — deliberately.**
- **Setup:** Among the documents pinned to the board sits a "smoking-gun" Vestry memo Adam never sourced firsthand (**C-25**, seeded off-screen by Nine on Marr's orders). It must be visibly on the board from this scene — present, unremarked, provenance-less from the moment it appears (binding staging).
- **Solution:** Run the board's **audit provenance** sort: every card files as *surface-sourced*, *below-sourced*, or *unsourced*. Exactly one card is unsourced — and it is visually distinct **only under scrutiny** (binding: C-25 is acquirable only unsourced). A player who audits can flag it, refuse to weight it, and warn Duval — which changes *dialogue acknowledgment*, not plot (A3-S07 still happens; her byline hunger, not the player, publishes). **Fair because:** the Law of the Ledger has been systemic since Act II began — every other card in the game carries source metadata; the game taught the sort and left one anomaly in plain, ignorable sight.
- **Clues:** **C-25** (the poison pill), fair-play flagged from the moment it appears. MYSTERY_LOGIC.md §5 sequencing: it must sit on the board at least two missions before A3-S07 so its detonation feels like the player's own oversight.
- **Fail states:** None mechanical — *not auditing is the fail state*, and it is paid narratively at A3-S07. Players who audited "get to be smarter than the canon" — the intended NG+/mastery reward.
- **What it advances:** The game's thesis about evidence: provenance is ammunition. Sets up A3-S07's reversal and the finale's rule that the lattice is built exclusively from below-sourced, clean-provenance strands (A4-S09).

---

## 5. Act III — Purgatory

### P-A3-S03-1 — "Hidden in Plain Sight"
- **Scene / Location:** A3-S03, LOC-meridian-trust (gala floors).
- **Type:** System obstacle — **Social Engineering** at full depth + **Forgery** deployment (Nine's invitation).
- **Mandatory. SETPIECE — the game's precision peak.**
- **Setup:** The Renewal's victory-lap fundraiser. Adam hidden in plain sight among people who only ever looked at his mugshot — forged invitation by Nine (scripted quality: canon events don't hinge on a grind), suit from Kray's rag trade. Rook warned "abort" (C-29 — the first tip whose beneficiary is unclear; the ambiguity is the clue).
- **Solution:** Deploy the invitation at the checkpoint (quality meets scrutiny — pass band scripted), then **blend**: pretexts (waiter's tray, contractor's clipboard, guest's champagne) as dialogue stances; conversation circles and work-tasks as mobile cover; performing the pretext's task resets suspicion; the news wall is an ambient hazard. Reach the private floor unnoticed. Zero sanctioned violence. **Fair because:** suspicion is per-observer and diegetic (gazes that linger); every escalation step has a Leverage talk-window before a run-window.
- **Clues:** C-29 logged (primes the audit instinct for A3-S12); the Aegis response afterward — too fast, Nine-brokered — ticks **C-21** for the standing correlation (P-A2-S09-1).
- **Fail states:** Graded social cascade — question → escort-out → alarm — with talk windows at each step; terminal exposure on the private floor escalates to evasion, not capture (canon guarantees exfiltration pressure). Sloppiness raises **Heat**'s band and tightens act-III windows.
- **What it advances:** Delivers Adam to P-A3-S03-2's prizes; stages the Kessler two-hander (everything true, nothing helpful — the antagonist-dialogue rule played straight: talk loses to documents).

### P-A3-S03-2 — "The Private Floor"
- **Scene / Location:** A3-S03, LOC-meridian-trust (Kessler's private floor).
- **Type:** Hybrid — Scene Reading (the gala floor / the office, canonical taxonomy instance) executed with the **Camera** under a leak-clock.
- **Mandatory.**
- **Setup:** Two prizes are somewhere in the private floor's paperwork: the indemnity annex and the escrow schedule. Aegis is already inbound (authored; Nine-brokered — the clock is the leak itself).
- **Solution:** Read the office as a scene — filing logic, what a woman like Kessler keeps close versus displays — locate both documents, and photograph them page by page under time pressure (focus/exposure discipline; blown pages cost retakes against the clock). The player should register two lines whose meaning outruns the scene: subsidiary acquisitions including **three remediation contractors**, and *"fountain & waterscape maintenance — $3.1M/yr — Larkspur Facility Services."* **Fair because:** the documents are complete and honest in the Case File afterward; the deliberate dryness (C-22 "diversification boredom") is the disguise, not missing information; Larkspur is a name the player personally lifted at A2-S11.
- **Clues:** **C-22** (remediation contractors — R2's cornerstone) and **C-34** (Nightingale's operating budget wearing a landscaping skin — links Trust money → Larkspur → the pump hall C-19).
- **Fail states:** Time pressure degrades photo quality or forces exfil with partial pages (Duval's decode still lands canonically at A3-S04 — the scene guarantees the haul, the player's performance shades how much Duval must reconstruct, acknowledged in dialogue).
- **What it advances:** The direct inputs of **R2** (A3-S04: "They're not hiding the poison. They're farming it.") and, via C-34, the finale plan's crew-rota intelligence (A4-S06).

### P-A3-S05-1 — "Ask the Window What the Rain Paid For"
- **Scene / Location:** Received A3-S05, LOC-voss-house; carried by the player; cashed at A3-S06, LOC-st-brigids.
- **Type:** Riddle Exchange (register 3: the idiom — a riddle carried to an object).
- **Mandatory (the carrying); solving it is aiming it.**
- **Setup:** The dying patriarch speaks only in the Vestry's idiom, half-confession, half-riddle: *"Ask the window what the rain paid for"* — and presses a watch-fob key into Adam's hand: "the family's memory is in the family's keeping."
- **Solution:** The Notebook transcribes the riddle; the board accepts it as a card; solving is done in the world, not a parser: connect "the window" to the violet window at St. Brigid's — the glass the player has been shown since the anniversary dinner (C-33: St. Brigid holding back a violet flood, behind Mara's shoulder for a whole scene) — and take the Verger there. **Fair because:** the referent has been planted visually since A0-S07 and named as iconography; the Verger's sacristan history (A2-S10) supplies the access; hints (Verger/Duval, after long idles) restate the reading rule — *the Vestry writes its business into consecrated objects* — never the answer.
- **Clues:** **C-23** (the riddle + the watch-fob key — a persistent inventory hero item that travels to A3-S14's strongbox and A4-S02's twin lock); **C-32** named on screen in the same scene (the dye-worker's disease — poisoner and poisoned share a pathology).
- **Fail states:** Unsolved idiom riddles simply wait; no lock, no timer. 
- **What it advances:** Unlocks A3-S06; begins RH-05's on-screen collapse (the "mastermind" is a frightened penitent); arms the two-key geometry of the endgame.

### P-A3-S06-1 — "The Receipt in Glass"
- **Scene / Location:** A3-S06, LOC-st-brigids (nave, night; scaffold lamp as diegetic light).
- **Type:** Vestry Cipher (donor-panel payment cipher — the receipt-reading lesson).
- **Mandatory.**
- **Setup:** The violet window, read properly at last, with the Verger and his Concordance folio keys. Three-element puzzle station: the 1975 "restoration" donor panel (names and amounts), the lancet inscriptions, and the folio cross-reference.
- **Solution:** Apply the hymn-rule literacy from A2-S10 one level up: the donor panel is not a memorial, it is a **ledger page** — names key to folio entries via the lancet inscriptions; amounts reconcile as payments. The decode resolves the window into **a receipt, in glass, for the Quiet Covenant** — continuity of Vestry knowledge, 1974 onward, hidden in the one building Lowmarsh would never demolish. The window physically re-lights as understanding lands (staging canon: the glass goes from *pretty* to *documentary*). **Fair because:** the grammar is the taught cipher family's second lesson, scaffolded by the Verger in-scene; every key element is on a legible surface at reading height.
- **Clues:** **C-24** decoded; **C-33 payoff** (the truth stood witness over the marriage, unread — and the sacristy wedding photo lands the gut-punch free of charge).
- **Fail states:** None hard; mis-keys get the reading rule restated. No enemies, no timer — a church at night and a torch.
- **What it advances:** Provable continuity of knowledge (discovery-map row 8); the receipt-reading grammar that A4-S02's chamber 3 (ledger-stones) recombines — taught here bindingly before the crypt (GAMEPLAY.md §8.7).

### P-A3-S08-1 — "The Needle, Wrong Forever" *(authored instance — no player input by design)*
- **Scene / Location:** A3-S08, LOC-squat.
- **Type:** Scene Reading (canonical taxonomy instance: "legible only to family").
- **Non-interactive** (the scene withholds music, mercy, and interactivity alike).
- **Setup:** Theo dead in a supervised-looking squat: staged overdose, needle in his arm. The city shrugs.
- **Solution:** None asked of the player's hands — and that is the design. Adam reads the scene in one breath because *Theo fainted at needles* (the A0-S06 flu-shot joke). The room is staged *almost* right — and the needle is wrong forever. The player who noticed C-26 three acts ago reads the murder simultaneously with Adam; the player who didn't receives it as revelation and can verify it against their own memory of the joke. **Fair because:** C-26 was planted as throwaway humor on the critical path three acts before its payoff (MYSTERY_LOGIC.md §1: planted A0-S06, payoff A3-S08).
- **Clues:** **C-26 payoff** (staged-overdose tell; corroborated later by Marr-archive cleanup records, A4-S09).
- **Fail states:** None. Listed here because GAMEPLAY.md §7 names it a canonical Scene Reading instance: it is the taxonomy's demonstration that scene-reading is knowledge, not pixel-hunting — the "puzzle" was solved at A0-S06 by paying attention to a brother.
- **What it advances:** The low point; the grief that A3-S10 prices. Nothing mechanical — maximum cost, zero difficulty, by canon.

### P-A3-S10-1 — "The Transit Yard"
- **Scene / Location:** A3-S10, LOC-transit-yard.
- **Type:** System obstacle — pursuit gauntlet (**Stealth**/traversal hybrid, symmetric flood physics) resolving into a **Confrontation**-adjacent standoff and a tracked valve.
- **Mandatory.**
- **Setup:** Nine's channels cough up the cleanup detail: Lt. Dane Krebs, Aegis, handled Theo. Adam hunts him through dead rolling stock, hissing third rails, knee-deep water.
- **Solution:** Two-phase arena. (1) **The hunt:** parallel pursuit lanes with cut-throughs via open carriages; Krebs runs high across the signal bridge — mirror or flank below; floodwater slows both movers equally (tension from symmetric physics, not rubber-banding — athletic but fair). (2) **The corner:** a dead-end pocket, no exit for Krebs, no audience — the valve: **kill / flip / walk away** (tracked, never moralized; canonical: evidence over blood). On *every* path the player exits holding Krebs's phone and geotagged Aegis field notes — **evidence acquisition is path-independent (binding)**. **Fair because:** the pursuit uses established traversal literacy; the choice is presented in silence with no UI flourish and no trick.
- **Clues:** **C-21 payoff** — the geotag map scrolls pin after pin, all Nine: the interception pattern becomes undeniable (closing the standing puzzle P-A2-S09-1 for players who hadn't).
- **Fail states:** Losing the hunt resets pressure within the yard (retry pressure, not mission fail); the valve cannot be failed, only chosen. Kill raises nothing on any meter — **Heat is amoral and never shades the epilogue (binding)**; the choice is remembered in dialogue and epilogue prose only (`valve.krebs`).
- **What it advances:** The leak has a shape and the shape is Nine — authorizes A3-S11. Grief given a target and the creed choosing data over blood: the story's hinge from prey to player.

### P-A3-S11-1 — "The Proof, Card by Card"
- **Scene / Location:** A3-S11, LOC-forge-shop.
- **Type:** System obstacle — **Leverage** (the model interrogation: evidence presented from the **Field Notebook**/**Case File**).
- **Mandatory.**
- **Setup:** Confrontation at the forge-shop, played sorrowful, not shouting. The mission opens only with C-21's payoff in hand (guaranteed by A3-S10 on every valve path).
- **Solution:** Lay the correlation out on Nine's light table **card by card**: C-15 (Kray's warning), C-20 (the fortunes, the questions, the never-raided fact — retro-flagged from the player's own journal), C-21 (the pattern), and the geotags last. Nine folds when the last card lands. Tone choices (press / soothe / stay silent) shade the scene; the cards carry it. Then authorize the first counterfeed: a **false safehouse location** fed upward. **Fair because:** every card was earnable by the player's own play and is in their journal; the interrogation's outcome is guaranteed by its evidence prerequisites, so the drama is in *how*, not *whether*.
- **Clues:** Consumes C-15/C-20/C-21; **RH-01 debunked** in the same stroke (the pattern never touched Duval-only information). The mechanism revealed — Nine's sister, a dial Marr turns — is context for A4 (his sister walks free in the epilogue).
- **Fail states:** Interrogations never fail into reloads — they fail into worse information states; here the canon confession is prerequisite-guaranteed. The counterfeed resolves as authored consequence: Aegis burns an empty barge at dawn; the barge was Kray's, volunteered; **the Ferrywoman is in**.
- **What it advances:** Nine flipped to triple agent (counterfeed contact-ability unlocks); Kray committed; **Heat's scripted floor drops** to its lowest since Act 0 ("one clean week"); exactly one unaudited channel remains — the premise of A3-S12.

### P-A3-S12-1 — "Three Envelopes"
- **Scene / Location:** A3-S12, LOC-lantern (dispatch; meet sites deliberately unregistered).
- **Type:** Correlation (experimental design — the canary trap).
- **Mandatory.**
- **Setup:** With Nine controlled, one leak remains possible: the channel Adam never audited because it only ever *gave*. Sequencing constraint (binding, MYSTERY_LOGIC.md §5): Nine's unmasking must precede this — the trap's logic requires all other channels closed.
- **Solution:** Design and dispatch the trap: three meets, three channels, **each fed a different location** — the player chooses the three channels' baits; ROOK9 alone gets the church option. Then watch: **Aegis hits the church.** One variable isolated; one conclusion possible. **Fair because:** the player builds the experiment with their own hands, so the proof is theirs — the design is exactly the tracer logic of Adam's profession (inject a marked flow, observe where it emerges), applied to people; the game has been teaching that inference since A0-S03.
- **Clues:** Consumes C-29's primed doubt; produces the trap result that unlocks P-A3-S12-2.
- **Fail states:** None hard — bait assignments the player fumbles are corrected in the dispatch dialogue (the crew sanity-checks the design; hints restate the isolation rule, not the outcome).
- **What it advances:** Proof that the guardian-angel channel is the leak — "checkmate delivered by mail." The emotional trigger of R3.

### P-A3-S12-2 — "The Corpus" — R3
- **Scene / Location:** A3-S12, LOC-lantern (the board).
- **Type:** Correlation (corpus analysis — attribution by intersection).
- **Mandatory.**
- **Setup:** The trap says *which channel*; the corpus says *who*. Every ROOK9 artifact the player has banked since A1-S07 goes on the board.
- **Solution:** Assemble the intersection: engineering idiom in the annotations; allocution dates matching one supervision window (C-11); a warrant that knew the notebooks *and the count* (C-10 — population: one); forged math using a taught shortcut (C-06); the QA intercept sitting in the certification office (C-09); a persona named with a cipher-keeper's vanity (*Violet Marsh* — C-35); and *castle early, castle often* reproduced across nineteen ROOK9 games (C-14 + A0-S05's mentor-lore). Exactly one person sits in every set. **Rook is Ray Cordell.** (**R3**.) Flashback stitch: A0-S05's expensive nothing, replayed with sound on. **Fair because:** MYSTERY_LOGIC.md §6 certifies the architect solvable from Act I–II by exactly this intersection; every strand was planted at least one act prior; the player's resistance is emotional, not evidentiary — the mystery's armor is the player's affection, same as Adam's.
- **Clues:** Consumes **C-05, C-06, C-09, C-10, C-11, C-14, C-29, C-35** (the R3 input set, verbatim from the reveal dependency graph).
- **Fail states:** None — the scripted board-scene assembles the canonical connections regardless; players who pre-strung the name get the shortened scene and acknowledgment (and the long quiet where the game knows they knew).
- **What it advances:** **R3** — reveal-spine row 9 (never reorder). Aims A3-S13; re-grades every Rook tip the player ever obeyed; C-29 re-reads as protecting the *deal* — or, conflictedly, the student.

### P-A3-S13-1 — "Castle Late"
- **Scene / Location:** A3-S13, LOC-cordell-cabin.
- **Type:** System obstacle — **Leverage** by silence (stay-silent as a first-class verb) with a chess interaction; the taxonomy carries no entry here *by design* — the scene is nerve, not solve.
- **Mandatory.**
- **Setup:** Adam arrives as the student — no accusation, no wire, one chessboard. Two old men's rituals performed perfectly by two liars. Cordell offers escape money and a door (R4 pre-echo, played on the player's incomplete knowledge: they know *who*, not yet *why-him* — binding sequencing).
- **Solution:** Play the game and say nothing. The scene's only weapon is the player's own deliberate input: **castle late**, breaking the habit Cordell installed ("castle early, castle often" — A0-S05). No dialogue option announces it; the move *is* the message, and Cordell reads it for what it is. **Fair because:** the habit was planted as warm mentor-lore in Act 0 and re-surfaced as evidence in P-A3-S12-2; the game trusts the player to weaponize their own memory, and accepts the scene played straight (castling early) with Cordell left unsignaled — a quieter shading, acknowledged later.
- **Clues:** None gained; one *spent* — the corpus knowledge, converted into mutual unspoken understanding.
- **Fail states:** None mechanical. There is nothing to lose here but the gesture.
- **What it advances:** Both men know, and neither has said a word: the hunt is finally honest. The antagonist-advantage inversion completes — from this beat, Adam is ahead for the first time.

### P-A3-S15-1 — "The Chalk on the Gate" *(trigger solve)*
- **Scene / Location:** Trigger at LOC-cemetery (the gate); scene body A3-S15, LOC-st-brigids (night ward).
- **Type:** Scene Reading (signal literacy — the discarded's tradecraft, **Social Engineering**'s signal verb read in reverse).
- **Mandatory to trigger; the game converges hints if unrecognized.**
- **Setup:** Days after A3-S14, a chalked symbol appears at the cemetery gate. No objective marker points at it — **binding:** the game taught the clinic emblem at A3-S09 (Mara's pin left on Theo's headstone, held in close-up; Theo teased her about that pin — she'd never part with it idly) precisely so this mark is the *player's* recognition.
- **Solution:** Recognize the chalked clinic emblem as Mara's channel — her tradecraft, learned alone — and answer it (attend the signal; Kray-passage to the night ward). **Fair because:** the emblem has been on Mara's lapel since A0-S01, was isolated as a signal object at A3-S09, and the Undercroft's chalk-sign grammar has been ambient tradecraft since Act II (knowledge-as-ability: "reading the Below's warnings").
- **Clues:** Opens the scene that pays **C-01** (the cluster map rebuilt from twenty years of triage ledgers) and fully debunks **RH-03** (the backwards E; the phone's impossible purchase date — her own frame-crack, found unprompted).
- **Fail states:** Unrecognized, the mark waits; after long idles the Verger nudges with the reading rule (the discarded sign in chalk; the clinic signs in its own emblem), never the answer.
- **What it advances:** The marriage un-poisoned for the player (discovery-map row 10); the cluster map joins the board as a clean below-sourced lattice strand; C-32's pathology folds into evidence.

---

## 6. Act IV — Reckoning

### P-A4-S01-1 — "The Wire That Couldn't Exist"
- **Scene / Location:** A4-S01 (the Letters prep thread), LOC-lantern.
- **Type:** Document Forensics (date-check / anachronism hunt — the formal find of C-27).
- **Mandatory here; **optional-early from Act II** (the ledger enters the Case File at A1-S04; the anachronism is findable by hand from Act II — finding it early re-orders nothing and earns dialogue acknowledgment: Duval's authentication pass credits the player's earlier flag).
- **Setup:** Lena and Duval authenticate the family archive; Duval's formal authentication pass sweeps the frame's financial exhibits — including the public offshore ledger that convicted Adam in the press.
- **Solution:** **Date-check** the ledger's instruments: one backdated "2023" wire uses an interbank message format **that did not exist until 2024**. The money history is backdated fiction, provably — and whoever fed the DA the ledger fed him a forgery. **Fair because:** the ledger has been complete and honest in the Case File since Act I; the date-check verb has existed since A2-S08 (the same move that found a dead man's initials); the flaw is exactly one economical anachronism, per the frame's design logic (forging the past at scale races entropy, and entropy leaves receipts).
- **Clues:** **C-27** formally found (planted A1-S04; the frame's single technical flaw).
- **Fail states:** None — the authentication pass is scripted to land it; the player's contribution is the hands-on find within the pass (soft-gated spot with converging Duval dialogue).
- **What it advances:** The instrument that flips Hale at A4-S09 ("I was fed a case. I can prove it, because I kept what they fed me") and vacates the financial counts. RH-07's debunk is loaded here.

### P-A4-S01-2 — "The Route" (Kray's soundings)
- **Scene / Location:** A4-S01 (the Route prep thread), LOC-undercroft (the Vats approach).
- **Type:** System obstacle — **Waterline** + **Water Reading** prep beat (one beat per crew skill — this is the water crew's).
- **Mandatory (prep suite; the five threads are selectable in any order — the game's one mission-select window).**
- **Setup:** Kray runs the Vats approach — the toll finally paid in the coin she always meant: witness. Vesper's cone is tightening; the ceremony-day route must survive storm surge. **The Vats quarter of Kray's map renders for the first time** (binding: blank until A4-S01).
- **Solution:** Sound the channel with Kray: read datum lines, flow, and surge behavior along the approach; log the soundings and the abort thresholds into the Notebook — the route card the A4-S05 descent will run on. **Fair because:** it is the player's own Water Reading literacy applied at planning tempo, with Kray's expertise as the scaffold; nothing new is taught (no new grammar after Act III — binding).
- **Clues:** None new; operationalizes the A2-S11 approach knowledge and C-34's crew-rota intelligence.
- **Fail states:** None hard — misjudged soundings are corrected by Kray in dialogue (she has decades of hand-corrected margins); legacy **Heat** band affects prep-suite checkpoint scrutiny elsewhere, not here.
- **What it advances:** The descent route of A4-S05 and the flood-clock literacy the A4-S06 exam assumes; Kray's arc paid (witness as toll).

### P-A4-S01-3 — "Nine's Best Work"
- **Scene / Location:** A4-S01 (the Lie prep thread), LOC-forge-shop.
- **Type:** System obstacle — **Forgery** commission and deployment prep (GAMEPLAY.md §2.5.3).
- **Mandatory (prep suite).**
- **Setup:** Nine's last forgery, for the good guys this time: the credentials that put Adam's people inside the ceremony's service perimeter on Day V.
- **Solution:** Specify the job (what document, what checkpoint it must survive — Chen's sampling-pavilion perimeter under ceremony security), source the exemplars (the player's own photographed paperwork from three acts of jobs — a real reason the Camera mattered), and commission. Quality is **scripted-canonical** ("Nine's best work"; credentials scan green at A4-S05 under Whitlock's flat gaze) — canon events don't hinge on an optional grind. **Fair because:** the system's spec-exemplar-deploy loop has been playable since Act III; this instance is its graduation, staged to succeed.
- **Clues:** None new; consumes accumulated exemplar provenance.
- **Fail states:** None terminal — under-specified commissions bounce back in dialogue (Nine names what is missing); legacy Heat narrows the checkpoint-scrutiny margin at A4-S05's scan (tension, not failure).
- **What it advances:** The service-perimeter insertion that makes the finale's deployment possible; Nine's redemption arc given a deliverable.

### P-A4-S02-1 — "The Crypt Gauntlet" — R4
- **Scene / Location:** A4-S02, LOC-vestry-crypt (beneath St. Alban's).
- **Type:** Composite Gauntlet (the puzzle exam: hymn-cipher → ledger-stones → the twin lock; known grammar recombined — **never new**, binding).
- **Mandatory.**
- **Setup:** The drowned Vestry crypt, the club's first hall, flooded since 1968. No timer, no deaths, no enemies, no music through the entire gauntlet — difficulty entirely as cipher literacy. Chest-deep wading; one generous air-pocket traverse. The Verger leads; the watch-fob key rides in Adam's pocket.
- **Solution:** Three chambers, each an exam on a taught grammar:
  1. **Chambers 1–2 — the hymn rule** (A2-S10's grammar): frozen liturgical numbers key inscription surfaces; the player indexes and extracts exactly as taught at the drowned chapel above.
  2. **Chamber 3 — the ledger-stones** (A3-S06's receipt-reading grammar, recombined): founders' floor-stones read as ledger lines — names, amounts, reconciliation — locating the strongroom recess beneath a founder's ledger-stone.
  3. **The twin lock** (paired-input): Voss's watch-fob key (C-23) is one half; **the Verger's spoken half** — remembered, not written — is the other. Two exiles' halves united; only the discarded, together, can open the ledger. Thematically load-bearing and mechanically literal: a key the player carried for an act, and a man the player learned to trust against RH-04.
  Inside: the **Concordance** (cipher-minutes 1877–1974, the Quiet Covenant vote), the routing copy of **Cordell's 1988 certification** with the Quorum secretary's annotation — *"The young man signed. He will be of use for thirty years."* — and the archive-heist **choreography memo**. **Fair because:** every grammar element was taught by a mandatory instance acts earlier (curriculum, binding); recombination is the only novelty; hints restate the two reading rules.
- **Clues:** **C-17 payoff** (the choreography memo laid over the player's own heist map, matching beat for beat — P-A2-S07-2 re-graded before their eyes); **R3's full stitch** (C-09's intercept, the pre-drafted compromise order).
- **Fail states:** None — no fail-deaths, no timer; the crypt punishes haste only visually (wrecked black-mirror water). Breath-hold traverse is generous by canon.
- **What it advances:** **R4** — the First Lie, 1988; *why Adam*, complete: "You weren't framed for what you'd do. You were framed for what he did." Reveal-spine row 11 (never reorder). Recovers the lattice's spine document for A4-S07/S09.

### P-A4-S05-1 — "The Descent"
- **Scene / Location:** A4-S05, LOC-undercroft → LOC-nightingale-hall approach (playable thread of the cross-cut).
- **Type:** System obstacle — **Waterline** as level clock (Vesper rules: routes close in real time).
- **Mandatory.**
- **Setup:** Day V. The livestreamed vote begins as Vesper arrives. Adam and Lena descend to the Nightingale hall through water already violet at the seams — the first hint the machine is losing.
- **Solution:** Run the P-A4-S01-2 route under live storm load: read closing routes by flow and datum line, choose fallbacks as Waterline states escalate (wading → chest-deep → swimming), keep Lena's pace. **Fair because:** the route was the player's own prep work; the closure logic is the Water Reading the game has taught since A0-S03; violet in the water is plot information (binding palette doctrine), here literally signposting the machine's failing margins.
- **Clues:** None new; the violet seams are R0's truth going kinetic.
- **Fail states:** Soft — a closed route forces the logged fallback (time and tension, not death); scripted survivability where the cross-cut requires arrival.
- **What it advances:** Delivers Adam and Lena to the hall doors as the broadcast goes live — the finale's staging beat.

### P-A4-S06-1 — "The Re-Route" (the exam)
- **Scene / Location:** A4-S06, LOC-nightingale-hall (the two stacked valve galleries).
- **Type:** Hydraulic Routing (the full-grammar exam: three routing objectives under storm load and a rising **Waterline** clock).
- **Mandatory. The mechanical summit.**
- **Setup:** The pump hall at storm load, screaming. **Binding (Law of the Engineer / §8.9): this is a routing puzzle, not a demolition** — Adam does not destroy the Nightingale; he re-routes it, and the storm supplies the violence. The valve galleries share visual grammar with A2-S03's junction (curriculum continuity), and the geography is the player's own A2-S11 recon — the plan on the Notebook page cites their photographs and the lifted maintenance log.
- **Solution:** Three routing objectives, solved valve by valve, junction by junction, between floodwater stages: send seventy years of intercepted leachate *to daylight* — (1) the storm drains (Lowmarsh's streets), (2) the plaza's showcase fountain loop, (3) the ceremonial first-draw main. Each objective is a contamination-isolation problem *inverted* — the player has spent the whole game routing poison *away*; the exam is routing truth *toward* — same grammar, reversed intent, which is the plot in puzzle form. Lena works the junction wheel as the second pair of hands. **Fair because:** the grammar is A2-S03's, taught mandatorily; the layout is A2-S11's, walked personally; destination gauges and sluice indicators are the same props the player has read for three acts; and C-34 supplied the crew rotas that explain the hall's staffing state.
- **Clues:** Executes on **C-19/C-34** knowledge; the act of re-routing is what makes A4-S07's live chemistry — TS-19/44 re-validated against the water itself — possible (Tracer Logic's narrative payoff).
- **Fail states:** **Failure = setback, never death (binding):** a mis-route backs pressure into a gallery and costs the player a Waterline stage (water rises; the route to the next valve bank lengthens); the puzzle cannot become unwinnable. Reveals land at rest — the Marr standoff triggers only after the routing commits.
- **What it advances:** THE SCENE (A4-S07): the sky testifies; you cannot indict the rain. The player's difficulty is spent here so the payoff can be a broadcast — "A4-S07's broadcast miracle is retroactively the player's homework."

### P-A4-S06-2 — "The Standoff" *(optional branch — the game's hardest fight)*
- **Scene / Location:** A4-S06, LOC-nightingale-hall.
- **Type:** System obstacle — **Confrontation** (optional Marr branch of the tracked valve).
- **Optional (canonical path: let him walk).**
- **Setup:** Aegis's crew arrives — and behind them, Marr, file in hand: his own name in the Vestry's ledger (A4-S03's mail, received and believed — he is the one man professional enough to believe evidence about himself). He gives the only order left that serves *order*: "Contract's void. Fall back." **Choice valve (tracked, `valve.marr`):** let him walk (canonical) / fight him.
- **Solution (if fought):** The game's single hardest encounter by design guarantee — the hall's flood mechanics *are* the fight: footing, current, machinery hazards; environmental resolution over attrition (no health bars, no gun economy). **Winning it is colder, not better** — no shaded variant is a punishment ending, and none is a reward.
- **Clues:** None; **R5's payoff** (the fixer walks off the board) lands on the canonical path; the fight branch converges to the same A4-S07.
- **Fail states:** Death → reload at phase checkpoint (the one hard-fail domain). Both branches converge on A4-S07; the choice shades A4-S09's disposition of Marr (proffer and trial vs. death in the hall) and epilogue text. He never apologizes for Theo on any path.
- **What it advances:** The valve's meaning: the player prices the man, not the case — the case was already won at the valves.

---

## 7. Standing rules for Phase 3 quest/level implementation

1. **Tag discipline:** every implemented puzzle carries exactly one taxonomy type from GAMEPLAY.md §7; system obstacles carry their system name(s) and are not taxonomy entries. Adding a taxonomy type requires updating GAMEPLAY.md §7 first, then this document.
2. **Placement is canon:** plants and payoffs sit exactly where MYSTERY_LOGIC.md §1–§2 and §5 put them. Moving any entry above means reconciling that registry (and TIMELINE.md §4's reveal spine — rows 5, 7, 9, 11 never reorder) before touching this file.
3. **Solvability audit:** each entry's "fair because" clause is a testable claim. Playtest protocol: a reader with only the cited priors must be able to solve; a reader without them must be caught by the critical path's scripted assembly. Both audiences are canon.
4. **The two grammars stay spatially distinct** (hydraulics below and in working spaces; ciphers in the Vestry's liturgical ledger-spaces) and meet exactly once — A4-S02 keys the plan, A4-S06 executes it. That adjacency is the plot; do not add crossover instances.
5. **No puzzle pads time.** Every entry above names its story payload (clue, reveal, debunk, curriculum, or valve). A proposed puzzle that cannot fill in "What it advances" with a C-/RH-/R-/curriculum reference is cut or rehomed.
6. **Favor Board content** (repeatable favors, 20–40 min, authored, no proc-gen) may exercise any taught system but may not plant, move, or pay off any C-/RH- item, and gates nothing on the critical path. Favors are practice space for the grammars, never mystery carriers (MYSTERY_LOGIC.md rule 3).

---

*End of PUZZLES.md v1.0. Companion documents: [`GAMEPLAY.md`](GAMEPLAY.md) (systems & taxonomy), [`../storyboard/SCENES.md`](../storyboard/SCENES.md) (staging), [`../narrative/MYSTERY_LOGIC.md`](../narrative/MYSTERY_LOGIC.md) (clue registry — binding). Any change to a puzzle's placement, inputs, or payoff reconciles against MYSTERY_LOGIC.md §5 and TIMELINE.md §4 before it lands here.*
