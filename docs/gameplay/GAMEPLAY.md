# PURPLE RAIN — Core Gameplay Design (v1.0)

> **Phase 2 gameplay design.** The core mechanics, systems, and structure of *Purple Rain*, derived exclusively from the narrative canon — [`../narrative/STORY.md`](../narrative/STORY.md) (scriptment, esp. §10 design hooks), [`../narrative/MYSTERY_LOGIC.md`](../narrative/MYSTERY_LOGIC.md) (clue web), [`../narrative/TIMELINE.md`](../narrative/TIMELINE.md) (calendar) — and the production storyboard — [`../storyboard/SCENES.md`](../storyboard/SCENES.md) (58 scenes), [`../storyboard/LOCATIONS.md`](../storyboard/LOCATIONS.md) (30 locations), [`../storyboard/CHARACTERS.md`](../storyboard/CHARACTERS.md). Any conflict resolves in favor of the narrative docs, then the storyboard, then this document. This document expands (and supersedes the sketch level of) `../GAME_DESIGN.md` §Design Pillars, including its core-loop summary.
>
> **ID conventions:** scenes `A<act>-S<scene>` (A0-S01…A4-S11), characters `CH-*`, locations `LOC-*`, clues `C-##`, red herrings `RH-##`, reveals `R0`–`R5` — all canonical, used verbatim, never coined here.
>
> **System names in bold Title Case** (e.g. **Case File**, **Heat**, **Tracer Kit**) are canonical for all later phases: quest specs, UI copy, and code identifiers should derive from them.
>
> **Spoiler policy:** total spoilers. Playtesters and blind contractors should not read this document.

---

## 0. The one-line design thesis

**Adam Vale solves the city like a hydraulics problem.** He is an engineer, not a soldier — methodical, allergic to shortcuts, the person you call when the numbers feel wrong. Every mechanic below is his profession or his predicament made playable: reading water, reading documents, reading people, and — when the record turns on him — learning the crafts of the discarded. Nothing in this design gives the player a verb Adam could not plausibly learn in 31 weeks from the people of the Undercroft. There is no gunplay progression, no XP, no morality meter. There is competence, memory, evidence, and consequence.

Two derived laws that every system honors:

- **Law of the Engineer:** when the player wins big, it is by *routing*, not destroying (A4-S06: he re-routes the Nightingale; the storm supplies the violence). Combat exists to be scarce, physical, and priced.
- **Law of the Ledger:** everything the player collects has *provenance*, and provenance is gameplay. Documents from tainted channels betray you (C-25); documents from the discarded convict the powerful (A4-S09's lattice). The UI never hides where a thing came from.

---

## 1. Core Loop

```
INVESTIGATE ──▶ INFER ──▶ ACT ──▶ CONSEQUENCE
     ▲                                 │
     └─────────── one rung deeper ─────┘
```

Four phases, each owned by a system family:

| Phase | What the player does | Primary systems | Where it lives |
|---|---|---|---|
| **INVESTIGATE** | Gather: examine, photograph, sample, eavesdrop, steal documents, interview | **Field Notebook**, **Camera**, **Tracer Kit**, **Document Forensics**, **Leverage** | In-mission, in-world |
| **INFER** | Connect: pin evidence, correlate patterns, decode ciphers, spot discrepancies, choose the next target | **Evidence Board**, **Case File**, puzzle grammars (§7) | The Lantern war room (from A2-S08); Case File anywhere |
| **ACT** | Execute: infiltrate, heist, tail, confront, forge, flip, re-route | **Stealth**, **Confrontation**, **Waterline**, lawbreaking kit (§2.5), **Social Engineering** | Mission spaces |
| **CONSEQUENCE** | Pay and learn: **Heat** shifts, allies react, the conspiracy adapts, new leads open; the reveal ladder advances (R0–R5) | **Heat**, **Remembered Choices**, **Favor Board**, hub state changes | Return to hub; news drip; NPC dialogue |

**Rules of the loop:**

1. **Every ACT is authorized by an INFER.** Missions unlock from the Evidence Board, not from map markers. The player must connect at least the minimum clue set for a lead before the Favor Board / war room offers the mission (the "minimum set" per reveal is MYSTERY_LOGIC.md §5's dependency graph; the game may scaffold with Verger/Duval dialogue, never with an objective arrow).
2. **CONSEQUENCE is never skippable.** Each major mission returns through the hub (or a scripted aftermath scene) where the world's reaction is shown before the next lead opens. This is the delivery vehicle for the antagonist-advantage mechanics (MYSTERY_LOGIC.md §4): the player must *feel* Aegis adapt.
3. **The loop is Adam's creed, mechanized.** Investigate = "the data doesn't lie." Infer = "write it down." Act = what the frame forces. Consequence = "people do." NG+ players should recognize the loop itself as the theme.

### 1.1 How the loop shifts per act

The loop's four phases never change; their *weights and stakes* do. This is the difficulty curve's skeleton (§5) and the fiction's arc.

| Act | Loop skin | INVESTIGATE | INFER | ACT | CONSEQUENCE |
|---|---|---|---|---|---|
| **Act 0 — Grace** (A0-S01…S08) | *Grounded routine.* The loop taught in civilian trim, stakes invisible | Examine the ordinary; the flow-map anomaly (A0-S03); the Fig. 12 discrepancy (A0-S04) | The Notebook as habit; the first Document Forensics compare | Send one email (C-04). The act's only "action" is living | The raid. The player's own diligent click detonates their life — the loop's first lesson: consequence is real |
| **Act I — The Fall** (A1-S01…S09) | *Evasion.* The loop runs backwards — the system investigates *him* | Read what they built: charge sheet (C-11), ledger, bail (C-12); find Theo's tells (A1-S06) | Case File debut; no board yet — inference is private, desperate | Evade: the scrum (A1-S03), the run (A1-S08). No crime verbs yet except flight | Each evasion strips more of the old life; Heat is scripted and absolute (§3.2) |
| **Act II — Hell** (A2-S01…S14) | *Survival & underworld economy.* "Everything below costs a favor; every favor is a mission" | Below-sourced truth: the leachate wall (A2-S03), Duval's wall (A2-S05), the pump hall (A2-S11) | Evidence Board debut (A2-S08, R1); first provenance sorting | Crimes of necessity: pharmacy run (A2-S02), the heist (A2-S07); stealth grammar matures | **Heat** proper comes online; the compromise order (A2-S09) teaches that wins can be their moves; bounty era (A2-S12) |
| **Act III — Purgatory** (A3-S01…S16) | *The long con.* From prey to player: targets picked from the war room | Finance (A3-S03/S04), ciphers-as-receipts (A3-S06), the leak's shape (C-21) | The board goes strategic: correlation views, canary trap (A3-S12), corpus analysis | Long-con jobs: the gala (A3-S03), flipping Nine (A3-S11), the cabin game (A3-S13) | Reversals priced in blood: A3-S07 (paper strategy dies), A3-S08 (Theo). The valves open (A3-S10) |
| **Act IV — Reckoning** (A4-S01…S11) | *Execution of the plan.* The loop inverts: nine days of INFER→ACT with no room for error, then the water testifies | Prep intelligence (A4-S01); the Concordance gauntlet (A4-S02) | The plan itself — the board's final lattice state; R4/R5 land | The finale suite: credentials, descent, the full-grammar re-route (A4-S06), the seal chamber (A4-S08) | Consequence goes public and permanent: A4-S07 broadcast; A4-S09 fallout; epilogue shading (§3.4) |

---

## 2. Mechanics

Each mechanic is specified as: **player verbs / UI surface / failure model**. Failure philosophy game-wide: **fail-forward wherever canon requires survivability** (the archive boat chase, the depot tutorial, the crypt); hard fail (reload) is reserved for combat death and blown terminal-stealth states, and even then checkpoints sit at phase boundaries, never at mission start.

### 2.1 Confrontation — first-person action

**What combat is:** scarce, physical, close, and expensive. Shoves, grapples, improvised strikes with the tools at hand (a boat-hook, a wrench, a valve wheel), disarms that end fights rather than start them, and above all *escape as the winning move*. Encounters are built like hazards, not arenas: two or three opponents maximum, environmental resolution favored (floodgates, darkness, water, collapsing catwalks).

**What combat deliberately isn't:** there is no gun economy. Adam never acquires a firearm as equipment; on the rare scripted occasion a gun enters his hands (disarm), it is a threat prop with a dialogue function, not a weapon system — holding it raises **Leverage** pressure and **Heat**, and the game offers no aim-and-fire loop beyond a warning discharge. No health-bar attrition duels, no takedown XP, no combo trees. Violence is priced (STORY.md §7): every fight leaves marks on Adam (visible damage states, limping traversal for the mission's remainder), raises Heat, and is remembered in dialogue.

- **Player verbs:** shove · grapple/struggle (mash-free, timing-based) · strike (improvised object) · disarm · break-away (the emphasized verb — every combat space has an authored exit) · drag/carry (bodies, and Theo in A2-S13, Cordell in A4-S08 — the same mechanic doing violence's opposite).
- **UI surface:** none beyond the reticle and damage vignette. No enemy health bars, no hit markers. Threat is read diegetically (posture, radio chatter, flashlight behavior).
- **Failure model:** death → reload at phase checkpoint. Non-lethal capture is used where fiction demands survivability (Act I) — a scripted near-catch, not a game-over screen. **Design guarantee:** the game's single hardest fight is the *optional* Marr branch at A4-S06; the canonical path through the entire game can be completed with under a dozen combat encounters.
- **Hard exclusions (from LOCATIONS.md):** no combat verbs load at LOC-seal-chamber (A4-S08 — remove affordances, not just the encounter), at LOC-lantern or LOC-st-albans (sanctuary rule), and **no mechanism exists to harm CH-theo in A2-S13** (inviolable).

### 2.2 Stealth — the Light / Sound / Sightline model

Three detection channels, each readable in-world, each with a counter Adam plausibly owns:

| Channel | Model | Player reads it by | Player counters it by |
|---|---|---|---|
| **Light** | Binary-ish lanes: lit / penumbra / dark; dynamic sources (flashlights, drone cones, lightning) carve moving lanes | The world itself — sodium pools, work-lights; no visibility gem. Rain diffuses light: heavier register = softer lanes | Crouching lanes, dousing/re-routing sources (a breaker is a valve — §2.5.2), waiting out sweeps |
| **Sound** | Surface-typed footsteps (grate / concrete / gravel-alarm strips / water) + masking layers (compressor hum, rain register, pump-throb) | Listening — masking sources are visibly/audibly running; subtitled sound-ripple UI at accessibility tiers only | Matching pace to masking (taught at LOC-depot: the compressor), route choice by surface, the rain itself — storms are stealth weather |
| **Sightline** | Classic vision cones with *attention* weighting: guards vs. workers vs. cameras. Workers (the Nightingale night crew, A2-S11) have narrow, task-locked attention but radios — the threat is escalation, not eyesight | Posture and task animation; camera sweep rhythms | Cover, verticality (shelf-tops at LOC-archive-annex, gantries), **social cover** in populated spaces (§2.5.4) |

- **Player verbs:** crouch · lean/peek · hide (containers, water, the pump casing at A2-S11) · distract (thrown object; opened valve) · douse light · listen (focus) · mark-by-photographing (Camera doubles as recon).
- **UI surface:** minimal — an awareness pip on humans only when they are actively acquiring Adam (three stages: glance → suspicion → alarm). No minimap, no x-ray. The **Field Notebook** auto-sketches patrol notes when Adam observes a loop twice (knowledge-as-ability, §4.3).
- **Failure model:** graded, location-tuned. Suspicion → search (recoverable); alarm → response escalation on a timer (mission continues under pressure); *hard* alarm states exist only where fiction says so. Tutorial spaces (LOC-depot) tune detection → chase-out, not reload: "the tutorial teaches consequence, not punishment" (LOCATIONS.md).

**The flooded-tunnel traversal — the Waterline system.** The Undercroft "experiences weather as rising water" (LOCATIONS.md); **Waterline** is the region-wide mechanic that makes water level a gate, a clock, a stealth channel, and a hazard:

- **States per space:** dry → wading (slowed, loud at speed, quiet at care) → chest-deep (no sprint, arms committed — no tools out except the sample vial) → swimming (stamina + cold timer) → breath-hold (air-pocket traverses; generous, never twitchy).
- **Reading the water is the counterplay:** every junction carries a visible high-water datum line; flow direction, sediment, and stain are legible (§2.3.2 Water Reading) so a player who reads like Adam predicts which routes close. In Vesper scenes (A4-S05/S06) Waterline becomes the level clock: routes close in real time, floodwater rises between puzzle stages.
- **Water as ally:** it masks sound, breaks pursuit (A2-S13's floodgate escape), hides Adam (submerged hides), and carries him (boats are moving cover; "the boat is the cursor" in cipher scenes at LOC-st-albans).
- **Failure model:** cold and stamina are soft timers driving the player to ledges and boats, not instant drowning; breath-hold failure pushes Adam to the last air pocket. Scripted drownings (A1-S08) are narrative, not systemic.

### 2.3 Investigation tools

Five surfaces, one doctrine: **evidence is an object with provenance**. Every collected item records *where, when, and through whom* it was obtained. This is not flavor — it is the mystery's fair-play machinery (C-25 must sit "provenance-less" on the board; A4-S09's lattice is won by clean provenance) and a core system readout.

#### 2.3.1 Field Notebook (the journal) & Case File (the document reader)

- **Field Notebook** — notebook #42, Cordell's gift, the diegetic journal. Auto-jots observations in Adam's hand; accepts player-flagged details ("filed by the game as thesis" — A0-S02); logs samples, patrol sketches, riddle transcripts, the plan. Tutorialized in A0-S01 *as his habit, not a menu*. The Notebook is also the story's object: the player writes the plan's first line in it (A3-S16) and hands its successor to a rookie in A4-S10.
- **Case File** — the reader for full documents: the charge sheet (46 counts, Count 31 findable — C-11), the plea allocution, the offshore ledger (C-27's anachronism findable by hand from Act II, formally found A4-S01), stolen escrow schedules, warrants. Documents are *complete and honest* — the fair-play audit (MYSTERY_LOGIC.md §6) requires that a careful reader can beat the reveals to the punch. Dense pages get a magnifier and a pin-to-board verb, never a summary that solves it for you.
- **Player verbs:** read · magnify · compare (two-up — see Document Forensics) · pin to board · annotate.
- **UI surface:** paper-diegetic; the Notebook in hand, the Case File as a satchel of physical documents. No lore-menu abstraction.
- **Failure model:** none. Reading never fails; *not* reading is the failure, and it is paid at the board (leads that don't open) and in the fiction (C-25: the one document Adam never sourced — players who audited provenance get to be smarter than the canon, which is the intended NG+/mastery reward).

#### 2.3.2 Tracer Kit & Water Reading

Adam's superpower is *reading water* — flow, pressure, sediment, stain (STORY.md §5.1 design note). Two coupled systems:

- **Water Reading** (perception, free, always-on): a focus verb that renders what Adam knows onto the world — flow direction at junctions, pressure anomalies (audible strain, gauge language), sediment and stain history (tide-lines, the violet seam), datum lines. It is Adam's expertise diegetically: no detective-vision ghost images, only the physics made legible. Taught at A0-S03 on the flow-map table; the same literacy reads the Undercroft, the Vats approach, and the finale.
- **Tracer Kit** (tool, deliberate, consumable-light): sampling vials + tracer dye + a field colorimeter (mechanical, battery-less — Rook's rule from A1-S07, "take nothing with a battery," is a canon constraint the equipment design must respect). Verbs: **sample** (log water at a point — labeled, dated, auto-filed; A2-S03's "old habit"), **trace** (release dye upstream, observe emergence downstream — the mechanic of TS-19/44 itself, used to prove connections between systems), **match** (compare a sample's signature against the library — the violet leachate signature is the game's recurring truth-key).
- **UI surface:** the kit is a physical roll-out; results are strips and vials logged into the Notebook. Trace results draw temporary flow-annotations in Water Reading focus.
- **Failure model:** traces can be *inconclusive* (wrong injection point, flow too low) — costing time and sometimes Heat (lingering in hostile space), never locking progress; every mandatory trace has multiple valid injection points.

#### 2.3.3 Document Forensics

The discrepancy-spot mechanic debuted at A0-S04 (archived Fig. 12 vs. notebook #29) and matured at A2-S08 (four-way assembly: original vs. doctored vs. notebook vs. sample).

- **Player verbs:** compare (two-up/four-up stations) · overlay (raking light, UV at Nine's forge-shop) · spot (click the discrepancy) · date-check (the anachronism hunt: initials of a man dead 14 months — C-18; a wire format that didn't exist — C-27) · authenticate provenance (chain-of-custody read).
- **UI surface:** a comparison bench (physical desk metaphor); found discrepancies pin as evidence cards with the *specific contradiction* named.
- **Failure model:** none hard. Mandatory spots (A0-S04) gate softly — Adam "can't shake it" until found, with Mara/Verger nudge lines after long idles. Optional spots (C-27 from Act II) are pure mastery reward: finding them early re-orders nothing (TIMELINE.md's discovery map holds) but changes *dialogue acknowledgment* — Duval's A4-S01 authentication pass credits the player's earlier flag.

#### 2.3.4 Camera (photography)

A mechanical film camera (battery-less; film developed at the Lantern's development tray, stock and chemistry supplied through Nine — provenance again: prints carry a develop-date).

- **Player verbs:** photograph (evidence, patrol layouts, the pump hall's framed shots at A2-S11) · develop (at the hub between missions) · pin/mail (prints go to the board — or, the act-II lesson, to someone who *can* use them: A2-S14's mailing of the H.G. print to Whitlock).
- **UI surface:** viewfinder with focus/exposure as a two-input skill (rushed shots come out unusable — tension in hostile spaces); a contact sheet in the Case File.
- **Failure model:** a blown shot costs a re-take or, if the moment has passed, downgrades the evidence card (usable on the board, not mailable — provenance quality is a real axis). Mandatory story photographs are re-attemptable in-scene.

#### 2.3.5 Evidence Board (the lattice)

The game's diegetic quest log and single most important interactive surface (LOCATIONS.md, LOC-lantern war-room alcove). Debuts A2-S08; grows for three acts; per-act dressing states are canon.

- **Player verbs:** pin · string (assert a connection — the board accepts wrong strings; it is a hypothesis surface, not an answer key) · correlate (the pattern view: mission-giver metadata vs. Aegis interceptions — the honest data that makes C-21 solvable at A2-S09) · audit provenance (sort every card **surface-sourced / below-sourced / unsourced** — the retrospective sorting MYSTERY_LOGIC.md §4 demands; C-25's card is visually distinct *only under scrutiny*) · brief (commit a lead → mission unlock).
- **UI surface:** the physical board at the Lantern. Away from the hub, the Notebook carries a pocket summary — read-only; *inference happens at home*. This is a pacing valve (return-to-hub rhythm, §6) and a fiction rule (the board cannot be captured because it never leaves the one place the Vestry can't see).
- **Failure model:** wrong strings persist until contradicted — the board lets the player believe RH-01…RH-08 and then experience the debunks as *corrections they can watch happen* to their own handwriting. The board never blocks the critical path: canonical connections assemble in scripted board-scenes (A2-S08, A3-S12) whether or not the player pre-built them; players who did get shortened scenes and dialogue acknowledgment.

### 2.4 Dialogue & interrogation

#### 2.4.1 The Leverage model (pressure ⇄ evidence)

Conversation with stakes runs on two resources:

- **Pressure** — situational force: where the conversation happens, who controls exits, what Adam is holding, what the other party fears. Pressure opens *tones* (press / soothe / stay silent). It is mostly authored per scene, moved at the margins by player conduct (a drawn weapon spikes pressure and poisons trust; a lowered one is remembered).
- **Leverage** — evidence cards presented from the Notebook/Case File. Leverage opens *facts*. Presenting the right card at the right claim is the interrogation mechanic: the model scene is A3-S11, where the player lays the correlation out on Nine's light table **card by card** — C-15, C-20, C-21, the geotags — and Nine folds when the last card lands.
- **Player verbs:** choose tone · present evidence · stay silent (a first-class option — several canon beats are won by it: A3-S13's entire scene) · walk away.
- **UI surface:** dialogue choices carry no morality icons and no success percentages. Presented evidence renders physically (slid across tables). A subtle pressure read lives in the other character's animation, not in a meter.
- **Failure model:** interrogations do not fail into reloads; they fail into *worse information states* — a subject who stonewalls, lies, or bolts, each of which the board can catch later (a lie contradicted by a card becomes new leverage: "you said X; this says Y"). Canon-critical confessions (Nine's) are guaranteed by their scenes' evidence prerequisites: the mission that opens A3-S11 requires C-21's payoff in hand (which A3-S10 guarantees on every valve path — evidence is path-independent by design).

**Design rule — Kessler's grammar:** major antagonists never lie to the player (CH-kessler "never once lies"; every sentence technically true). Phase 3 writers must build antagonist dialogue that is *unhelpfully true*, so that Leverage play against principals yields admissions-shaped sentences that convict nobody — the player must learn that talk loses to documents, and documents lose to water. The dialogue system's ceiling is the theme.

#### 2.4.2 Riddle Exchanges (the Verger, and the Vestry's idiom)

Spoken riddles are diegetic (STORY.md §10: the Vestry's cipher culture; the Verger as riddle-mentor). Three registers:

1. **The door** (A1-S09 and every Lantern re-entry): the riddle-hatch — simple, teachable, a filter "for cops and fools." First-visit riddle is answerable from anything the player noticed in Acts 0–I (multiple accepted answers); later visits auto-resolve to a knock pattern (belonging, textured).
2. **The lesson** (A2-S10 onward): the Verger teaches the Vestry's symbolic language as call-and-response over real objects — hymn boards, plaques, glass. These exchanges are the tutorial layer of the **Vestry Cipher** puzzle family (§7): each riddle names a *reading rule* ("the number is the hymn; the hymn is the page") that the player then applies mechanically.
3. **The idiom** (A3-S05): Voss's half-confession — "ask the window what the rain paid for" (C-23) — is a riddle the *player* carries for a scene and cashes at A3-S06. Riddles of this register are quest keys: the Notebook transcribes them; the board accepts them as cards; solving them is done in the world, not in a text parser.
- **UI surface:** conversation, the Notebook transcript, and the objects themselves. Never an abstract riddle-box minigame.
- **Failure model:** wrong answers at the door get colder soup and a second try (the Verger is filtering intent, not IQ). Lesson riddles cannot fail — they are teaching. Idiom riddles unsolved simply wait; the Verger or Duval offer converging hints after long idles (hint doctrine: hints restate the *reading rule*, never the answer).

### 2.5 Lawbreaking systems

The crimes the law-abiding engineer learns, in the order hell teaches them. Each carries **Heat** on failure *and often on success* — lawbreaking is never free.

#### 2.5.1 Lockpicking

- **Fiction:** taught in A2-S02 (the pharmacy cage) — "he crosses the line… and the worst part is how good he is at it." Locks are machines; Adam is good with machines.
- **Player verbs:** pick (tension + feedback, skill-based and quiet-hands: rushing is loud) · raake (fast, loud — a choice, not an upgrade) · examine lock (Water Reading's cousin: the mechanism legible before the attempt).
- **UI surface:** first-person hands and tools; audio is the skill channel (feedback clicks under the environment's masking layer — picking during rain or compressor hum is genuinely easier: stealth and lockpicking share the Sound model).
- **Failure model:** broken picks (consumable friction, resupplied below), noise events feeding the Sound channel. Locks never gate the critical path exclusively — every picked door has a louder alternative (the design offers *quiet* as the reward, not *entry*).

#### 2.5.2 Systems Work (utility hacking)

There is no Hollywood hacking in Meridian, and Adam takes nothing with a battery. **Systems Work** is infrastructure exploitation — an engineer's literacy turned burglar's toolkit:

- **Player verbs:** read panels (alarm zones, armed states — the literacy taught at LOC-depot that A2-S07's exit-only panel assumes; a canonical curriculum link, do not cut) · re-route power/water (breakers, valves, pump interlocks — dousing lights, opening mag-held doors, moving masking noise) · clone/borrow credentials (badge-and-log systems — the frame's own vector, C-07, turned back on its makers; using a cloned badge writes a *false record*, which the fiction prices: Adam is doing to them what was done to him, and dialogue notices) · terminal work (records terminals and fiche readers — search and retrieval under time pressure, not password minigames).
- **UI surface:** the panels, breakers, and terminals themselves, in-world. Zone maps are printed cards on the wall by the panel, as in real buildings.
- **Failure model:** mis-reads trip what they were meant to disarm (alarm → escalation timer); credential use in the wrong zone flags the log (delayed Heat — the log is read *later*, teaching the game's deepest lesson: records are consequences on a timer).

#### 2.5.3 Forgery (with Nine)

Forgery is Nine's craft; Adam commissions, provisions, and deploys — the player never becomes a master forger, keeping CH-nine's craft legendary and load-bearing (his last forgery, A4-S01/A4-S03, must matter).

- **Player verbs:** specify the job (what document, what checkpoint it must survive) · source the exemplar (missions produce letterheads, seals, signatures — a real reason to photograph paperwork) · fund/favor it (the Undercroft economy) · deploy it (present at checkpoints — a Social Engineering beat where quality meets scrutiny).
- **UI surface:** commissions are specified at the Lantern (hub rule 1, §6.2) as a physical spec sheet; Nine executes at his forge-shop light table (LOC-forge-shop stays a story set — A3-S11, A4-S01 — not a recurring station); quality legible as craft (UV check, seal die match).
- **Failure model:** forgery quality × checkpoint scrutiny = outcome band (pass / pass-with-question / fail). A failed paper triggers social escalation, not instant alarm — there is always a *talk window* (§2.5.4) before a *run window*. The gala invitation (A3-S03) and the ceremony credentials (A4-S05, "Nine's best work") are scripted-quality: canon events don't hinge on an optional grind.

#### 2.5.4 Social Engineering

Hiding in plain sight among people who only ever looked at his mugshot (A3-S03).

- **Player verbs:** disguise (outfits with *zone permissions* — Kray's rag-trade suit, the gravedigger crew at A3-S09, service jackets) · pretext (a claimed role: waiter, contractor, mourner — pretexts are dialogue stances that reframe scrutiny) · blend (conversation circles and work-tasks as mobile cover; performing the pretext's *task* resets suspicion) · signal (the discarded's tradecraft: chalk marks, hymn-board numbers, a pin on a headstone — learned symbols the player must recognize themselves; the game teaches the clinic emblem at A3-S09 so A3-S15's chalk mark is the *player's* recognition, per LOCATIONS.md).
- **UI surface:** suspicion is per-observer and diegetic (dwell-and-proximity: gazes that linger, the news wall as ambient hazard). No global disguise meter.
- **Failure model:** graded — question → escort-out → alarm, with Leverage windows at each step. Terminal exposure in fortress spaces (the Trust's private floor) escalates to evasion, not mission failure; canon guarantees exfiltration pressure, not capture.

---

## 3. Heat — notoriety without a morality meter

STORY.md §10 is prescriptive: **no morality meter**. The three valves are "remembered by characters and epilogue text, not scored." **Heat** is therefore *not* a judgment system. It is the world's operational awareness of Adam — how hard the machine is currently hunting — and it is deliberately amoral: feeding insulin to the Lantern and burning a warehouse can both raise it.

### 3.1 What Heat is, mechanically

- A per-district **posture level** (0–4) driving: patrol density and type (police → Aegis → kill teams post-A2-S12), checkpoint scrutiny, watcher posts at Undercroft junctions, informant activity, price and iciness on the Favor Board, and news-drip tone at the hub.
- A **scripted floor** per act chapter, moved by canon events, with a **player band** (±1) above the floor moved by conduct: witnesses, alarms, bodies, flagged credentials raise it; lying low at the hub, Nine's papers, Kray's routes, and time decay it back to floor.
- **Two faces:** **Surface Heat** (the city's machine) and **Undercroft Wariness** (the Below's opinion — colder receptions, shrinking safe routes). They move independently: the bounty era (A2-S12) spikes Wariness by script; sloppy surface jobs spike Surface Heat without touching the Below.

### 3.2 Heat per act

| Act | Scripted floor | Player band behavior | What it changes on screen |
|---|---|---|---|
| **Act 0** | System off. No Heat UI exists | — | Nothing. The act's dread is dramatic irony, not mechanics |
| **Act I** | Absolute and authored: the machine's pursuit is the *plot* | No band. Player conduct cannot lower Act I Heat — the system is functioning, for someone else | Scrum density, raid timing, the impossibility of surface life. Teaching: this Heat was never yours to manage |
| **Act II** | Onlines at A2-S02 (first crime). Floor steps up at **A2-S09** (records-compromise fallout; snatch squads) and hard at **A2-S12** (kill-team era + Undercroft bounty) | Full band active. Job conduct matters for the first time | Aegis response posture on missions; watcher posts; Favor Board tone; whether supply-drop routes are burned |
| **Act III** | High floor, then the canon inversion: after **A3-S11** (Nine flipped, false counterfeed) the floor *drops* to its lowest since Act 0 — "one clean week," delivered as silence in the soundscape | Band matters most here: the long con punishes sloppiness with tightened windows (gala response times, meet security) | Mission insertion options; how fast Aegis arrives when things go loud; NPC willingness at the margins |
| **Act IV** | Heat is superseded: Vesper and the ceremony set security posture by script. Legacy band affects prep-suite checkpoint scrutiny (A4-S01) and the A4-S05 credentials scan — its last mechanical breath; nothing after A4-S05 | Narrow | Credential-check tension; nothing after A4-S05 — the finale is beyond hiding |

### 3.3 Heat as the fair-play red-herring engine

One deliberate interlock: heat *explains away* the leak. When Aegis lands fast on a Nine-brokered job, a heat-conscious player attributes it to their own notoriety ("they're everywhere" — the canonical fugitive paranoia, C-21's surface read). But the journal's mission-giver metadata is honest and the correlation view exists from A2-S09. **Rule for all phases:** leak-driven interceptions are *authored* and tagged internally as such; heat-driven responses are systemic; the two must remain distinguishable in retrospect (the player must be able to audit that near-misses correlate with Nine's brokerage and *not* with their own heat band) or the fair-play guarantee of MYSTERY_LOGIC.md §6 breaks.

### 3.4 Remembered Choices — the valves

The game is a canonical single spine with **tracked, converging choices** that shade — never branch — the plot:

| Beat | Choice | Converges on | Remembered where |
|---|---|---|---|
| **A2-S13** — the commitment beat | Take Kray's way out / refuse (canonical: refuse; taking it is a refused-offer scene, not an alternate game) | A2-S14 | The Verger and Kray reference the refusal; grounds the epilogue's "chose to climb" text |
| **A3-S10** — Krebs | **kill / flip / walk away** (canonical: evidence over blood). Evidence acquisition is path-independent — C-21's payoff lands on every branch | A3-S11 | Nine's flip scene tone; Kray and Duval dialogue; Whitlock's arm's-length trust; epilogue text |
| **A4-S06** — Marr | **let him walk (canonical) / fight him** — the fight is the game's hardest encounter, and winning it is *colder, not better* | A4-S07 | A4-S09's disposition of Marr (proffer and trial vs. death in the hall); Whitlock's fallout lines; epilogue text |
| **A4-S08** — Cordell | **let the water take him / leave him to the flood / drag him out for trial (canonical)** — all three play from identical blocking (series rule, LOCATIONS.md) | A4-S09 | A4-S09's Cordell disposition; the arrest-report beat exists only on the canonical path; epilogue text |

**Implementation rules:**

1. **No meter, no score, no summary screen.** The record of these choices lives in a hidden flag set (`valve.commitment`, `valve.krebs`, `valve.marr`, `valve.cordell`) surfaced *only* through character dialogue and epilogue prose. No UI ever itemizes them.
2. **Surfacing in A4-S09/A4-S10:** the fallout montage swaps its Marr and Cordell segments per valve state (trial footage vs. absence-shaped alternatives); the epilogue (A4-S10) shades per SCENES.md — e.g., the Mara coffee beat's final lines, the Verger's benediction callbacks, whether the rookie-notebook handoff plays warm or rueful. Phase 3 must write each shaded variant so that *no variant is a punishment ending*: the design position is that the canonical path is the most *resonant*, not the "good," outcome. Marr "never apologizes for Theo. Some doors stay shut" — on every path.
3. **Characters remember before the epilogue.** Each valve has at least two mid-game acknowledgments (the A3-S10 choice is referenced in A3-S11 and A4-S04 at minimum). Memory, not meters, is the consequence system.
4. **No other choice is tracked.** Side conduct (heat band, optional evidence) colors ambient dialogue only. Resist adding valves — three plus the commitment beat is the canon set (STORY.md §10).

---

## 4. Progression — competence, not stats

Nothing in *Purple Rain* levels up. Four things progress, all diegetic:

### 4.1 Tools

Acquired at canon beats, never upgraded on trees: notebook #42 (A0-S05) · lockpicks (A2-S02) · **Tracer Kit** assembled below (by A2-S03) · the mechanical **Camera** (early A2, film via Nine) · boat-handling (Kray-taught, self-poled from mid-A2) · commissioned forgeries (per job) · the watch-fob key (A3-S05 — a persistent inventory hero item through A3-S14 and A4-S02). Tool acquisition is finished by mid-Act III; the back half of the game deepens *use*, not kit.

### 4.2 The safehouse — the Lantern's state ladder

The hub improves as the *story* invests in it, not via purchase menus (state ladder per LOCATIONS.md: riddle door → orientation → evidence board alive → wariness/watch bell → war room → despair state → prep workshop → eve → legal Lantern). Functional growth: the board's views (correlation view from A2-S09, corpus analysis A3-S12, lattice A4), the favor board's scope, the map table (districts fill in as Passage opens), development tray (Camera), and mail-out (the Whitlock channel after A2-S14 — a repeatable *provenance-preserving* verb: photograph, seal original, mail print; fugitives can't fire evidence, cops can).

### 4.3 Knowledge-as-ability (the real skill tree)

The player's head is the progression system. Knowledge unlocks are earned by *doing*, logged in the Notebook, and honored by the world:

| Knowledge | Learned at | Unlocks |
|---|---|---|
| Journal/notebook habit | A0-S01 | The entire investigation surface |
| Flow-map & tracer logic | A0-S03 (Sector 9 anomaly) | Water Reading literacy; the puzzle grammar of the whole game |
| Security-panel literacy | A2-S02 (LOC-depot) | Reading the archive annex's exit-only alarm (C-17 oddity #4) — and every panel after |
| Valve-network grammar | A2-S03 (the Name Trade, full depth) | Every sluice/weir gate; the A4-S06 exam assumes it |
| Vestry cipher: hymn-number rule | A2-S10 (drowned chapel) | Plaque ciphers; the A3-S06 window; A4-S02 chambers 1–2 |
| Vestry cipher: receipt-reading | A3-S06 (the window) | Donor-panel/payment ciphers; A4-S02 chamber 3 (ledger-stones — known grammar recombined, never new) |
| **Pump-hall routing** | A2-S11 (recon: photographs, the maintenance log, the machine's layout) + A2-S03's grammar | **The A4-S06 re-route is only plannable because Adam walked the hall and kept the log** — the A3-S16 plan cites the player's own photographs; the finale's valve galleries reuse A2-S11's learned geography. This is the flagship knowledge-unlock: the midpoint's terror becomes the endgame's competence, and A4-S07's broadcast miracle is retroactively *the player's homework* |
| Undercroft routes & tradecraft | Act II living (knock patterns, chalk signals, tide tables) | Faster/safer traversal options; reading the Below's warnings; the A3-S15 gate signal |
| The playbook's shape | A2-S05 (Duval) | The player's own meta-defense: recognizing well-poisoning before A3-S07 (they usually won't — C-25 is the lesson) |

**Rule:** knowledge unlocks are *checked, not gated*. A player who somehow reads the exit-only panel without the depot lesson isn't blocked — the curriculum guarantees teaching order on the critical path (depot before annex, A2-S03 before A4-S06), and later content assumes it.

### 4.4 Contacts-as-abilities

Allies are verbs: **Kray** = Passage (districts/routes — §6) and exfil; **Nine** = Forgery and (post-A3-S11) counterfeed; **the Verger** = cipher tutoring, sanctuary, the Concordance; **Duval** = financial decode and, eventually, the story that runs second; **Whitlock** = the mail-out channel (provenance that can act); **Lena** (from A3-S14) = clean-provenance authentication and the finale's second pair of hands; **Mara** (A3-S15, hers to grant) = the cluster ledger. Contact abilities arrive on story schedule; favors deepen willingness at the margins but never purchase plot.

---

## 5. Difficulty curve — act by act across the 58 scenes

Philosophy: difficulty tracks the fiction's pressure, not a rising stat sheet. Adam gets *better* while the problems get *harder*; the player should feel growth even as tuning tightens. Three canonical setpieces are the landmarks; note that the first landmark is a *designed lie*.

| Act (scenes) | Target feel | Dominant skill tested | Tuning notes |
|---|---|---|---|
| **Act 0** (A0-S01…S08, ≈45–60 min) | Zero challenge, total absorption | Observation only | No fail states. The only "puzzle" difficulty is optional noticing (C-07, C-08). The raid is interactive helplessness — input without agency, by design |
| **Act I** (A1-S01…S09, ≈2 h) | Vertigo; scripted losses; one real gauntlet | Reading documents under grief; first evasion | A1-S08 is the act's spike: the evasion gauntlet tuned tense but completion-guaranteed on retry (checkpoints per leg). Everything else fails forward — the act's losses are authored |
| **Act II** (A2-S01…S14, ≈4 h) | Learning hell's trades; real failure begins | Stealth, Waterline, first full puzzles | Curriculum ramp: A2-S02 (forgiving tutorial) → A2-S03 (first full-depth hydraulics puzzle) → **A2-S07 LANDMARK: the Archive Heist — deliberately *easy*.** The level is genuinely under-defended (skeleton crew is a mechanical fact) and the escape is scripted-survivable: peak *tension*, low *lethality*. The player must leave feeling brilliant; A4-S02 re-grades the feeling. Do not "fix" this level's easiness in tuning passes — it is C-17's delivery mechanism → A2-S11 (the act's true stealth peak: the pump hall, one hide, radio-threat crew) → A2-S13 (chaos escape under the no-harm-Theo envelope) |
| **Act III** (A3-S01…S16, ≈4 h) | Mastery under reversals; the con | Social stealth, Leverage, correlation | **A3-S03 LANDMARK: the Trust gala** — the game's precision peak: social-stealth grammar at full depth, forged-credential deployment, document work under a leak-clock, and zero sanctioned violence; failure cascades are social then evasive. Mid-act the *game* fights back narratively (A3-S07, A3-S08 — no mechanical difficulty, maximum cost). A3-S10's hunt is athletic but fair (symmetric flood physics); A3-S12/S13 are inference and nerve, not dexterity |
| **Act IV** (A4-S01…S11, ≈3 h) | The exam; every debt called | Everything, in sequence | A4-S01 prep suite: moderate, varied (one beat per crew skill). A4-S02: the puzzle exam — no timer, no deaths, difficulty entirely as cipher literacy (known grammar recombined). **A4-S06/S07 LANDMARK: Nightingale/Purple Rain** — the mechanical summit: the full-grammar valve re-route under storm load and rising Waterline (three routing objectives, failure = setback, never death), followed by the optional hardest fight (Marr branch) — and then A4-S07 pays the whole game as a *cutscene*: the player's difficulty was already spent authoring it. A4-S08: zero mechanical difficulty by fiat (no combat verbs load); the hardest input is the valve choice |

**Cross-act tuning rules:** (1) never spike dexterity demands inside reveal scenes — reveals land on players at rest; (2) accessibility tiers may soften timers and detection, never puzzle logic — the ciphers and hydraulics are the game's identity and must be solved, with the hint doctrine (§2.4.2) as the floor; (3) the two "hardest" moments in the game are both *optional refusals of the canon* (fighting Marr; letting Cordell drown against an assisted-climb the game makes effortful on the save path — LOC-seal-chamber's "earning it physically").

---

## 6. Structure — the Lantern hub-and-spoke

Per STORY.md §10 (structure recommendation, adopted): **hub-based — the Lantern as safehouse hub from Act II, districts unlocked by Kray-Passage; Acts 0–I linear.** Locations are authored sets and corridors, not open-world cells (LOCATIONS.md's standing assumption).

### 6.1 The shape

```
ACT 0–I : LINEAR RAIL                    ACT II–III : HUB-AND-SPOKE                ACT IV : CONVERGENT RAIL
A0-S01 → … → A1-S09                                                               A4-S01 (prep, hub-based)
(one-way; sets consumed                     ┌── Surface Lowmarsh spokes            → A4-S02 → A4-S03 → A4-S04
 and abandoned — the                        │   (St. Brigid's, Duval's flat,       → A4-S05 → A4-S06 → A4-S07
 rowhouse is never                          │    betting café territory)           → A4-S08 → A4-S09 → A4-S10
 revisited: restoration       THE LANTERN ──┼── Undercroft spokes                  (→ A4-S11 post-credits)
 refused at the level-        (hub: board,  │   (junctions, Kray's waters,
 design level)                 favor board, │    forge-shop, St. Alban's)
                               soup, cot)   ├── Institutional spokes (surface,
                                            │    Passage + credentials required)
                                            └── Cathedral Hill spokes (Act III)
```

### 6.2 Hub rules

1. **The Lantern is the loop's INFER station.** Board work, briefing, development, forgery commissions, favor pickup, and rest happen here; the pocket Notebook summary covers the field. The hub's 15 canonical beats (LOC-lantern's state ladder) are the game's emotional barometer — hub state must always match the calendar (TIMELINE.md §2), including the soundscape's storm register.
2. **Spokes open by Passage, not by map purchase.** **Passage** is Kray's system: districts and routes unlock when the fiction pays her toll (A2-S04 negotiation; favors; after A3-S11, alliance). Her map-with-a-blank-quarter *is* the world map UI in Act II–III — the Vats quarter renders blank until A4-S01, a canonical withholding no side content may violate (nobody ferries to the Vats; A2-S11 approaches by wading, off-map).
3. **Two mission classes on one surface.** The **Favor Board** posts *favors* (the Undercroft economy: supply runs, fix-its, escort jobs — the repeatable texture of Acts II–III, tuned 20–40 min, each teaching or exercising one system) and the war room posts *leads* (story missions unlocked by board inference). Favors gate nothing on the critical path; they buy Heat decay, contact warmth, materials/exemplars, and worldbuilding. Scope guardrail: favors are authored (no proc-gen), and their count is a content-budget dial, not a design dependency.
4. **Return-to-hub is the pacing valve.** Story missions end in aftermath (CONSEQUENCE) and route through the hub before the next lead opens — this is where news drip, ally scenes, and antagonist adaptation are staged. Exceptions are canon's scene-pairs that chain directly (A2-S07→S08, A3-S10→S11→S12→S13's cascade, the whole finale).
5. **Interleaved-perspective scenes** (A3-S02 and the A4-S09 montage) are *witnessed from Adam's world* — courthouse fragments via Duval's sources, news at the hub, remote beats framed as reports. The player is never re-seated in another playable character: **Adam is player-locked** for the entire game (canon).
6. **Act transitions re-skin the structure:** Act II opens the hub (A2-S01) with two spokes and grows to full spread by A2-S10; Act III adds Cathedral Hill and surface spokes under bounty-era pressure; A4-S01 converts the hub into the prep suite (five prep beats selectable in any order — the game's one moment of mission-select freedom, resolving into the fixed finale rail at A4-S02). After A4-S05 the game is a one-way convergent rail to credits, and should feel like water finding its level.
7. **Sanctuary invariants:** no combat verbs, no Heat accrual, no surveillance mechanics inside the Lantern or St. Alban's — ever. The Lantern is never physically raided (canon explains why: rule 3, the moving cots); threat reaches it only as *procedure changes* (the watch bell, the second plank).

---

## 7. Puzzle design — the two grammars and the taxonomy

Canon resolves riddle authorship (STORY.md §10): puzzles are diegetic, in **two families** — *Adam's hydraulics grammar* (his profession) and *the Vestry's cipher culture* (their century of hiding business in consecrated plain sight). The two families stay **spatially distinct** (LOCATIONS.md rule): hydraulics lives below and in working spaces; ciphers live in the Vestry's liturgical ledger-spaces. They meet exactly once, at the endgame (the crypt gauntlet keys the plan; the pump hall executes it) — which is the plot in puzzle form.

Canonical **puzzle taxonomy** (Phase 3 quest/level designers must tag every puzzle with one type; new types require updating this section):

| Type | Grammar family | Definition | Canon instances |
|---|---|---|---|
| **Hydraulic Routing** | Engineer | Valve/sluice networks: route flow from source to target under constraints (pressure, contamination isolation, load) | A0-S03 (Sector 9, tutorial); A2-S03 (full depth); recurring gates/weirs; **A4-S06 (the exam: three-objective re-route under Waterline clock)** |
| **Tracer Logic** | Engineer | Prove a connection: inject, observe, infer the hidden pathway; match signatures | A0-S03 flow-map; A2-S03 sampling; Vats-margin work; TS-19/44 re-validation against live chemistry (A4-S07, narrative payoff) |
| **Vestry Cipher** | Vestry | Decode the consecrated ledger: hymn-number keys, dedication-plaque and donor-panel ciphers, ledger-stones, glass-as-receipt | A2-S10 (hymn board → Covenant fragment); A3-S06 (the window, C-24); A4-S02 chambers (known grammar recombined) |
| **Riddle Exchange** | Vestry | Spoken diegetic riddles: door filters, taught reading-rules, idiom keys carried to objects | A1-S09 (the Lantern door); Verger lessons; C-23 ("ask the window what the rain paid for") |
| **Document Forensics** | Engineer (applied to paper) | Discrepancy-spot, anachronism hunt, provenance audit on documents | A0-S04 (Fig. 12); A2-S08 (four-way assembly; C-18); C-27 (optional-early, formal at A4-S01) |
| **Correlation** | Engineer (applied to events) | Pattern assembly on the Evidence Board: metadata vs. incidents; corpus analysis; the lattice | C-21 interception pattern (solvable from A2-S09); A3-S12 canary trap + ROOK9 corpus; A4-S09 lattice (narrative payoff) |
| **Scene Reading** | Both | Wrongness checklists: read a staged or choreographed space against earned knowledge | A3-S08 (the squat — legible only to family, C-26); A2-S07's four oddities (C-17, readable-but-deniable); the gala floor |
| **Composite Gauntlet** | Both | Multi-chamber exams recombining known grammars, plus paired-input locks (key + memory) | **A4-S02 (the crypt: hymn → plaque → ledger-stones → the twin lock: watch-fob key + the Verger's spoken half)** |

**Family rules:** (1) *no new grammar after Act III* — Act IV recombines, never introduces (the crypt's ledger-stones are "new combination of known grammar, not new grammar"); (2) every grammar element is taught by a mandatory instance before any high-stakes instance assumes it (the curriculum table, §4.3); (3) puzzles never hard-fail — cost is time, Heat, or tension, and the hint doctrine restates reading rules only; (4) puzzle *solutions are knowledge*: solving inscribes Notebook entries that later content references (puzzles are the progression system wearing its other hat).

---

## 8. Guardrails for Phase 3 (binding)

The rules later phases must not break, gathered:

1. **No morality meter, no karma UI, no choice summary screens.** Four tracked flags (A2-S13, A3-S10, A4-S06, A4-S08), remembered in dialogue and epilogue prose only. All valves converge; valve choices play from identical blocking; evidence outcomes are path-independent (A3-S10 rule).
2. **Adam is player-locked**; interleaved beats are witnessed, not played. The Aegis vault extraction (A4-S03) stays off-screen; expanding it is a canon change routed through STORY.md.
3. **Inviolables:** no mechanism to harm CH-theo (A2-S13); no combat verbs at LOC-seal-chamber, LOC-lantern, LOC-st-albans; no firearm progression for Adam; A2-S07 stays *easy* (the trap is the tuning); the Vats quarter of the map stays blank until A4-S01.
4. **Provenance is systemic:** every evidence item carries source metadata; C-25 must be acquirable only unsourced and visually distinct only under scrutiny; the surface-sourced / below-sourced / unsourced sort must be possible in retrospect across all Act II–III gains (MYSTERY_LOGIC.md §4's structural counter-mechanic).
5. **Fair-play interlocks:** leak-driven Aegis interceptions are authored and internally tagged, distinguishable in retrospect from Heat-driven responses; the journal's mission-giver metadata is always honest; clue plants/payoffs stay exactly where MYSTERY_LOGIC.md §5 puts them, and the reveal spine (discovery-map rows 5, 7, 9, 11) is never reordered.
6. **Diegesis discipline:** journal = Notebook, quest log = Evidence Board, map = Kray's map, tools are battery-less where Rook's rule applies; no detective-vision ghosts; no minimap; hints restate reading rules, never answers.
7. **Curriculum order is load-bearing:** depot panel literacy before the annex; A2-S03 valve grammar before A4-S06; cipher lessons before the crypt; the clinic emblem taught (A3-S09) before the chalk signal (A3-S15). Cutting a teaching beat requires re-homing its lesson.
8. **Heat is amoral and non-judgmental**; it never shades the epilogue. Scripted floors move only at canon beats (A2-S02, A2-S09, A2-S12, A3-S11, A4-S05).
9. **The engineer's law at the finale:** A4-S06 is a routing puzzle, not a demolition; failure states are setbacks, not deaths; the player's A2-S11 recon (photographs, maintenance log) must be visibly cited in the A3-S16/A4-S01 plan so the knowledge-unlock reads as earned.
10. **Tone guards:** violence scarce and priced; administrative horror stays administrative (no gothic security theater in institutional spaces); the purple palette doctrine (LOCATIONS.md) binds any new gameplay VFX — violet in water is plot information, never decoration.

---

*End of GAMEPLAY.md v1.0. Companion Phase 2 documents: `../storyboard/SCENES.md`, `../storyboard/LOCATIONS.md`, `../storyboard/CHARACTERS.md`. Any Phase 3+ quest, level, system, or UI work that renames a system, adds a puzzle type, moves a teaching beat, or touches a valve must update this document and reconcile against MYSTERY_LOGIC.md's registries first.*
