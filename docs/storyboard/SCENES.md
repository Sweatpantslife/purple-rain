# PURPLE RAIN — Scene-by-Scene Storyboard (v1.0)

> **Phase 2 production storyboard.** The complete scene graph of *Purple Rain* — all **58 scenes**, Acts 0–IV, in play order. Derived exclusively from the narrative canon: [`../narrative/STORY.md`](../narrative/STORY.md) (scriptment), [`../narrative/MYSTERY_LOGIC.md`](../narrative/MYSTERY_LOGIC.md) (clue web), [`../narrative/TIMELINE.md`](../narrative/TIMELINE.md) (chronology). This document adds staging depth, not new canon: any conflict resolves in favor of the narrative docs.
>
> **Spoiler policy:** total spoilers from the first page. Playtesters and blind contractors should not read this document.

## Legend

- **Scene IDs:** `A<act>-S<scene>` (e.g. `A2-S07`). Character IDs `CH-*` and location IDs `LOC-*` are canonical and shared with [`LOCATIONS.md`](LOCATIONS.md) and the narrative docs.
- **Clue / reveal tags:** clues `C-##`, red herrings `RH-##`, reveals `R0`–`R5` — all as defined in `MYSTERY_LOGIC.md`. Plants and payoffs are staged **exactly** where the reveal graph puts them; do not move one without updating `MYSTERY_LOGIC.md`.
- **Location links** point at [`LOCATIONS.md`](LOCATIONS.md) using the anchor convention `LOCATIONS.md#loc-<name>` (LOCATIONS.md must expose one anchor per `LOC-*` ID). Secondary locations are marked *(sec)*.
- **Player objective:** what the player is doing; authored scenes are marked `cutscene/non-interactive`. "Mixed" scenes are authored but contain significant interaction (dialogue choice, puzzle, examinable documents).
- **Choice valves:** the game is a canonical single spine with tracked choices that shade (never branch) the plot: the **A2-S13 commitment beat**, and the three formal valves at **A3-S10** (Krebs), **A4-S06** (Marr), **A4-S08** (Cordell). **A4-S11** is an optional post-credit sting. No morality meter; choices are remembered by characters and epilogue text.
- **Dating:** Day 0 = the raid (A0-S08). The game spans ≈31 weeks, April → early November, ending on ratification day in Storm Vesper. No calendar years appear on screen.

## Scene graph (ID → prev / next)

| ID | Title | Prev | Next | Branch / notes |
|----|-------|------|------|----------------|
| **Act 0 — Grace** ||||
| A0-S01 | "Anniversary Morning" | — (game start) | A0-S02 | Tutorial; C-01 plant; C-32 seed (Gabriel's photograph) |
| A0-S02 | "The City in the Rain" | A0-S01 | A0-S03 | C-02 plant |
| A0-S03 | "The Waterworks" | A0-S02 | A0-S04 | C-03 plant; C-28 referenced |
| A0-S04 | "The File" | A0-S03 | A0-S05 | C-04 plant — the tripwire |
| A0-S05 | "Chess with Ray" | A0-S04 | A0-S06 | C-05, C-06 plants |
| A0-S06 | "Theo" | A0-S05 | A0-S07 | C-07, C-26 plants |
| A0-S07 | "The Anniversary" | A0-S06 | A0-S08 | C-33, C-08 plants |
| A0-S08 | "Purple Dawn" | A0-S07 | A1-S01 | C-09, C-10 plants; SMASH TITLE |
| **Act I — The Fall** ||||
| A1-S01 | "Intake" | A0-S08 | A1-S02 | C-11 plant; RH-07 begins |
| A1-S02 | "The Offer" | A1-S01 | A1-S03 | C-13 plant; plea refused |
| A1-S03 | "Anonymous Grace" | A1-S02 | A1-S04 | C-12 plant |
| A1-S04 | "House of Glass" | A1-S03 | A1-S05 | C-35 begins; ledger (C-27 carrier) goes public; C-32 texture (Voss frailty) |
| A1-S05 | "Everything, In Order" | A1-S04 | A1-S06 | C-07 payoff #1; RH-03 planted |
| A1-S06 | "Theo's Silence" | A1-S05 | A1-S07 | Behavioral clue texture |
| A1-S07 | "The Second Wave" | A1-S06 | A1-S08 | C-14 begins; RH-08 planted |
| A1-S08 | "The Run" | A1-S07 | A1-S09 | Setpiece |
| A1-S09 | "Below" | A1-S08 | A2-S01 | End of Act I |
| **Act II — Hell** ||||
| A2-S01 | "The Rules of Below" | A1-S09 | A2-S02 | RH-04 planted |
| A2-S02 | "First Job — The Pharmacy Run" | A2-S01 | A2-S03 | RH-02 texture |
| A2-S03 | "The Name Trade" | A2-S02 | A2-S04 | R0 begins; C-02 payoff #1 |
| A2-S04 | "The Ferrywoman's Price" | A2-S03 | A2-S05 | C-15 plant |
| A2-S05 | "Iris" | A2-S04 | A2-S06 | C-16 plant |
| A2-S06 | "Rook's Second Gift" | A2-S05 | A2-S07 | RH-02 texture |
| A2-S07 | "The Archive Heist" | A2-S06 | A2-S08 | MIDPOINT; C-17 plant |
| A2-S08 | "Reading the Water" | A2-S07 | A2-S09 | **R1**; C-18; RH-06 planted + debunked |
| A2-S09 | "Heat" | A2-S08 | A2-S10 | RH-01 planted; C-21, C-20 begin |
| A2-S10 | "The Vestry Surfaces" | A2-S09 | A2-S11 | C-19 opens; RH-05 planted; RH-02 & RH-04 debunked |
| A2-S11 | "Nightingale" | A2-S10 | A2-S12 | **R0 completes**; C-19 |
| A2-S12 | "What They Say I Am" | A2-S11 | A2-S13 | RH-08 murder; kill-team era begins; C-20 texture (Nine never raided) |
| A2-S13 | "The Choice in the Dark" | A2-S12 | A2-S14 | **Commitment beat** (tracked); C-07 payoff #2 |
| A2-S14 | "Act Turn — Out of Hell" | A2-S13 | A3-S01 | C-18 mailed; C-25 sits unsourced on the board; End of Act II |
| **Act III — Purgatory** ||||
| A3-S01 | "The Ascent Plan" | A2-S14 | A3-S02 | War room; RH-05 build |
| A3-S02 | "Whitlock Bites" | A3-S01 | A3-S03 | Interleaved perspective; Hale's obstruction on record |
| A3-S03 | "The Trust Job" | A3-S02 | A3-S04 | SETPIECE; C-22, C-34, C-29; C-20 completes |
| A3-S04 | "The Meaning of Money" | A3-S03 | A3-S05 | **R2** |
| A3-S05 | "Voss's Summons" | A3-S04 | A3-S06 | C-23, C-32; RH-05 collapsing |
| A3-S06 | "The Window" | A3-S05 | A3-S07 | C-24; C-33 payoff |
| A3-S07 | "Duval's Gun Jumps" | A3-S06 | A3-S08 | THE REVERSAL; C-25 detonates; C-30 plant |
| A3-S08 | "Theo" | A3-S07 | A3-S09 | THE LOW POINT; C-26 payoff |
| A3-S09 | "The Funeral" | A3-S08 | A3-S10 | RH-03 debunk begins |
| A3-S10 | "Rage" | A3-S09 | A3-S11 | **CHOICE VALVE:** kill / flip / walk away (converges; tracked); C-21 payoff |
| A3-S11 | "The Rat" | A3-S10 | A3-S12 | Nine flipped; RH-01 debunked; Kray in |
| A3-S12 | "Canary Trap" | A3-S11 | A3-S13 | **R3** |
| A3-S13 | "One Last Game" | A3-S12 | A3-S14 | Advantage inversion completes |
| A3-S14 | "Lena" | A3-S13 | A3-S15 | C-30 payoff; RH-05 debunk completes |
| A3-S15 | "Mara's Ledger" | A3-S14 | A3-S16 | C-01 payoff; RH-03 fully debunked |
| A3-S16 | "The Plan" | A3-S15 | A4-S01 | ACT TURN; End of Act III |
| **Act IV — Reckoning** ||||
| A4-S01 | "Nine Days" | A3-S16 | A4-S02 | Prep suite; C-27 formally found |
| A4-S02 | "The Concordance" | A4-S01 | A4-S03 | **R4**; C-17 payoff; R3 stitch |
| A4-S03 | "Marr's File" | A4-S02 | A4-S04 | **R5 armed**; C-31 |
| A4-S04 | "Eve of Vesper" | A4-S03 | A4-S05 | The earned quiet |
| A4-S05 | "Ratification Day" | A4-S04 | A4-S06 | FINALE BEGINS; cross-cut |
| A4-S06 | "The Nightingale Falls" | A4-S05 | A4-S07 | SETPIECE; **R5 payoff**; **CHOICE VALVE:** let Marr walk (canonical) / fight him (converges; tracked) |
| A4-S07 | "Purple Rain" | A4-S06 | A4-S08 | THE SCENE |
| A4-S08 | "The Undercroft Door" | A4-S07 | A4-S09 | **CHOICE VALVE:** drown / abandon / save (converges; tracked) |
| A4-S09 | "Fallout" | A4-S08 | A4-S10 | RH-07, RH-08 debunked; C-27 payoff |
| A4-S10 | "What Heaven Is Now" | A4-S09 | A4-S11 *(optional)* | EPILOGUE; valve-shaded text |
| A4-S11 | Post-credit sting *(optional)* | A4-S10 *(after credits)* | — (end) | Non-canonical-load-bearing sequel hook |

---

# ACT 0 — GRACE
*Day −3 … Day 0; spring, April. One playable day and the dawn that ends it. Tone: warm, ordinary, rain as comfort. Everything in this act is a loaded gun.*

### A0-S01 — "Anniversary Morning"

- **ID / Title:** A0-S01 — "Anniversary Morning"
- **Location:** [LOC-vale-rowhouse](LOCATIONS.md#loc-vale-rowhouse) — The Vale rowhouse
- **Time / Mood:** Day −3, 6:40 AM, soft spring rain — warm, ordinary, domestic
- **Characters present:** CH-adam (Adam Vale), CH-mara (Mara Vale)
- **What happens:** The game opens in bed to rain on the window and an alarm — the gentlest tutorial in the genre. Adam moves through his morning: kettle, notebook (#41, near-full) on the counter, keys, badge lanyard — every interaction teaching movement, examination, and the journal UI as *his habit*, not a menu. Mara, dressing for a clinic shift, banters about tonight's tenth-anniversary dinner, and drops, offhand and tired: "Three more kids on the ward this month from the Flats. Swear that neighborhood is cursed" (**C-01** planted as pure domestic color). The kitchen radio runs the Meridian Renewal ballot ad — "Ascension: A City Reborn" — over the weather report. On the same shelf as the notebooks, examinable: a photograph of **Gabriel Vale** — Adam and Theo's father, work coat and flat cap, the river behind him; examining it journals a quiet note: *pipefitter at the old Works; bladder cancer, 2007 — never connected to anything, like everyone in Lowmarsh* (**C-32** seeded as family history; its recognition beat waits at A3-S05). Key shots: the notebook shelf (forty-one spines, dated); Gabriel's photograph among them; Mara's clinic pin on her lapel; rain beading on the anniversary card on the fridge. The player leaves the house holding everything Adam is about to lose — the storyboard's job here is to make it worth losing.
- **Player objective:** Complete the morning routine; learn movement, interaction, and the notebook/journal system.
- **How it starts:** New game — cold open on the alarm at 6:40 AM.
- **How it ends:** Adam steps out the front door into the rain, umbrella up, toward the tram stop — seamless handoff into the A0-S02 traversal.
- **Links:** prev — (game start) / next A0-S02.

### A0-S02 — "The City in the Rain"

- **ID / Title:** A0-S02 — "The City in the Rain"
- **Location:** [LOC-meridian-streets](LOCATIONS.md#loc-meridian-streets) — Meridian streets & tramways *(sec: [LOC-marsh-gate](LOCATIONS.md#loc-marsh-gate), [LOC-lowmarsh](LOCATIONS.md#loc-lowmarsh), [LOC-vestry-row](LOCATIONS.md#loc-vestry-row) glimpsed)*
- **Time / Mood:** Day −3, morning, steady rain — establishing, wistful
- **Characters present:** CH-adam (Adam Vale); unregistered NPC: the pigeon-feeding folktale teller
- **What happens:** Walk-and-tram traversal from Lowmarsh to the MWA, built as a moving establishing shot of Meridian's three vertical layers: brick terraces and chronic puddles at street level, Ascension billboards over Lowmarsh scaffolding, a WHOSE WATER? protest sticker on the tram glass, and — from the elevated curve — the granite silence of Vestry Row on Cathedral Hill. In the Marsh Gate underpass the player passes the repainted graffiti: **WHEN THE RAIN RUNS PURPLE** (**C-02**), letters fresh over older buffed ghosts of themselves. An old man feeding pigeons tells the purple-rain folktale unprompted if engaged — the player files it as color; the game files it as thesis. Key shots: the tram window wiping Cathedral Hill into view; the underpass graffiti held a beat too long; violet neon from an Ascension ad reflected in a curbside puddle (invisible foreshadowing of A4-S07).
- **Player objective:** Get to work; optionally explore, talk to the folktale teller, and journal the graffiti.
- **How it starts:** Continuous from A0-S01 — exiting the rowhouse front door.
- **How it ends:** Adam badges through the MWA lobby doors; interior sound swallows the rain — cut to A0-S03.
- **Links:** prev A0-S01 / next A0-S03.

### A0-S03 — "The Waterworks"

- **ID / Title:** A0-S03 — "The Waterworks"
- **Location:** [LOC-waterworks](LOCATIONS.md#loc-waterworks) — Meridian Water Authority offices
- **Time / Mood:** Day −3, workday — confident, mundane, fluorescent
- **Characters present:** CH-adam (Adam Vale); unregistered NPCs: MWA colleagues
- **What happens:** The competence tutorial. A live low-pressure anomaly in Sector 9 lands on Adam's desk and he diagnoses it elegantly through the flow-map interface — teaching the tracer-logic puzzle grammar that will carry the entire game (this is Adam's superpower, *reading water*, introduced as a day job). Colleagues establish his standing — he's the one they call when the numbers feel wrong — and hallway smalltalk brushes past his 2019 promotion out of the integrity program (**C-28**, referenced as a career milestone; its true meaning waits for A2-S08). His P.E. stamp is shown, casually, in use: the object the whole plot orbits, framed like a stapler. In his inbox: a CLEARWATER-grant memo — *independent federal re-validation of historical hydrological records to commence; all engineers to confirm archival integrity of prior filings* (**C-03**). Mundane. Fatal.
- **Player objective:** Solve the Sector 9 flow-map anomaly; process the inbox (document-reading interaction on the CLEARWATER memo).
- **How it starts:** Continuous from A0-S02 — badging into the lobby, elevator to the flow-map floor.
- **How it ends:** The memo's archival-integrity instruction sends Adam to the records system to check his own old filings — direct handoff to A0-S04.
- **Links:** prev A0-S02 / next A0-S04.

### A0-S04 — "The File"

- **ID / Title:** A0-S04 — "The File"
- **Location:** [LOC-waterworks](LOCATIONS.md#loc-waterworks) — Meridian Water Authority offices (records terminal)
- **Time / Mood:** Day −3, workday — mundane, fatal in retrospect
- **Characters present:** CH-adam (Adam Vale)
- **What happens:** Dutiful, Adam pulls his old filings — including **TS-19/44**, the 2019 tracer study. First real use of the discrepancy-spot mechanic: Figure 12 in the archived copy doesn't match his memory, so he fetches field notebook #29 and lays the curves side by side — the archived curve is *wrong*: cleaner, sensor-error-shaped, someone else's math (**C-04**). He assumes a scanning mix-up and composes a one-line email to Records QA: "Archived TS-19/44 fig. 12 doesn't match field data — wrong version scanned? Happy to re-submit. — AV." The player presses Send. **This is the tripwire** (T-2026b: the mail is read within the hour by the certification office, and the "go" order is issued) — and the player will not know for ten hours of gameplay that this click ended Adam's life. Key shot: the cursor hovering on Send, held exactly as long as any other UI beat — no music sting, no telegraphing.
- **Player objective:** Compare archived Fig. 12 against notebook #29 (discrepancy-spot puzzle); send the QA email.
- **How it starts:** Continuous from A0-S03 — the CLEARWATER memo's confirm-archival-integrity task.
- **How it ends:** Email sent; a calendar ping — lunch chess with Ray on the roof — carries Adam (and the player, unknowing) away from the scene of the crime. Handoff to A0-S05.
- **Links:** prev A0-S03 / next A0-S05.

### A0-S05 — "Chess with Ray"

- **ID / Title:** A0-S05 — "Chess with Ray"
- **Location:** [LOC-waterworks](LOCATIONS.md#loc-waterworks) — Meridian Water Authority offices (rooftop cafeteria chessboard)
- **Time / Mood:** Day −3, lunchtime, rain paused under the awning — warm, paternal
- **Characters present:** CH-adam (Adam Vale), CH-cordell (Raymond Cordell)
- **What happens:** Lunch at the rooftop chessboard worn smooth by two decades of this ritual. Cordell is warm, wry, full of retirement-party jokes — and gifts Adam a new field notebook: "Forty-two. The data doesn't lie, people do. Write it down" (**C-05**: the mentor *gave* Adam the habit, and knows the count). Mentor-lore drops naturally through the game: "castle early, castle often"; the famous **Cordell shortcut** for aquifer-boundary math sketched on a napkin (**C-06**). Cordell asks, idly, what Adam's working on; Adam mentions the odd archive scan of the old tracer study — and there is a beat of nothing on Cordell's face, the most expensive nothing in the game (replayed with sound on at A3-S12; this is the scene players rewatch in NG+). Key shots: the napkin shortcut; Cordell's hand hovering one extra frame over the clock; notebook #42 sliding across the table into the story.
- **Player objective:** Mixed — play out the chess conversation (light move interaction + dialogue choices); receive notebook #42.
- **How it starts:** Calendar ping at the end of A0-S04; elevator to the roof.
- **How it ends:** Lunch ends on a laugh; time-skip to end of workday, Adam heading for the street exit — into A0-S06.
- **Links:** prev A0-S04 / next A0-S06.

### A0-S06 — "Theo"

- **ID / Title:** A0-S06 — "Theo"
- **Location:** [LOC-waterworks](LOCATIONS.md#loc-waterworks) — street outside the MWA *(sec: [LOC-vale-rowhouse](LOCATIONS.md#loc-vale-rowhouse), that evening)*
- **Time / Mood:** Day −3, late afternoon into evening, rain resuming — uneasy fraternal warmth
- **Characters present:** CH-adam (Adam Vale), CH-theo (Theo Vale)
- **What happens:** Theo intercepts Adam outside the office — too bright, too funny, new phone, asking for a "bridge" loan. Adam gives him less than he asks and more than he should; the scene plays as a hundred previous versions of itself, which is the point. Environmental storytelling for the attentive: betting slips in Theo's jacket, a second phone in his pocket. A needle-drop of foreshadowing played entirely as a joke — Theo, deflecting Mara's flu-shot nagging: "You know me and needles. I'd rather have the flu" (**C-26**; six acts of sorrow are keyed to this laugh line). That evening at home, dressing for dinner, an optional environmental detail at Adam's desk drawer: **the spare MWA badge isn't in it** (**C-07** — the frame's physical-access vector, planted as nothing at all).
- **Player objective:** Handle the loan conversation (dialogue); optionally observe Theo's slips and second phone; at home, prepare for the anniversary dinner (the drawer is examinable).
- **How it starts:** Exiting the MWA at end of day; Theo is waiting under the awning.
- **How it ends:** Adam and Mara leave the rowhouse dressed for dinner; cut to the restaurant — A0-S07.
- **Links:** prev A0-S05 / next A0-S07.

### A0-S07 — "The Anniversary"

- **ID / Title:** A0-S07 — "The Anniversary"
- **Location:** [LOC-lowmarsh-restaurant](LOCATIONS.md#loc-lowmarsh-restaurant) — The anniversary restaurant *(sec: [LOC-st-brigids](LOCATIONS.md#loc-st-brigids) visible through the window)*
- **Time / Mood:** Day −3, evening, rain thickening — warm, romantic, watched
- **Characters present:** CH-adam (Adam Vale), CH-mara (Mara Vale); unregistered background: the photographing stranger (Aegis)
- **What happens:** Tenth-anniversary dinner in the small Lowmarsh restaurant across from St. Brigid's — where they married. Through the rain-streaked window, the church's violet-tinted glass glows under its floodlight (**C-33** — the window depicts St. Brigid holding back a violet flood; visible now, comprehensible only in Act III: the truth stood witness over their whole marriage, unread). A real marriage on screen: jokes that have worn smooth, a shared dessert, and the toast — "Ten years. Nothing about us in the papers. May it stay boring." Outside, under an awning, a stranger takes their photograph and does not lower the phone (**C-08** — Aegis pre-operation surveillance, three days before the raid; staged so only attentive players clock it). Key shots: the violet window soft-focus behind Mara's shoulder for the entire scene; the toast in silhouette; the phone that doesn't come down, held at the edge of frame.
- **Player objective:** Cutscene/non-interactive.
- **How it starts:** Cut from the rowhouse door at the end of A0-S06.
- **How it ends:** They walk home under one umbrella through thickening rain; time-skip card — *three days later* — into the dark before A0-S08.
- **Links:** prev A0-S06 / next A0-S08.

### A0-S08 — "Purple Dawn"

- **ID / Title:** A0-S08 — "Purple Dawn"
- **Location:** [LOC-vale-rowhouse](LOCATIONS.md#loc-vale-rowhouse) — The Vale rowhouse
- **Time / Mood:** Day 0, 5:50 AM, hard rain — violent rupture
- **Characters present:** CH-adam (Adam Vale), CH-mara (Mara Vale); unregistered: raid team
- **What happens:** Adam, sleepless-ish, checks email in the blue dark: his QA note has bounced — *recipient not found* (**C-09** — the intercepted inbox, played as a server glitch on a bad morning). Doorbell. Then the door. **The raid**, played interactively and helplessly: hands on the wall, the house strip-searched around him, Mara's face across the room, evidence bags filling with their life. The warrant is glimpsed for two seconds — re-readable later in the Act I case file — listing with impossible specificity *"personal field notebooks (approx. 41 vols.)"* (**C-10**: only someone who knew the private habit, and the count, could have sworn that line; population: one). The notebooks are seized — all but #42, Cordell's gift, still in the car. Perp walk into the rain, flashbulbs strobing the wet street violet-white. **SMASH TITLE: PURPLE RAIN.** Key shots: the bounce message; the two-second warrant insert; notebook spines going into bags one by one; the title hitting on a flashbulb.
- **Player objective:** Mixed — check the email, answer the door, endure the raid (constrained interaction by design: the player can look, comply, and read, but not resist).
- **How it starts:** Time-skip from A0-S07; the pre-dawn email check.
- **How it ends:** Title card over the perp walk; the game hands Adam, cuffed, from home to machine — direct cut to A1-S01 booking.
- **Links:** prev A0-S07 / next A1-S01. Act break: end of Act 0.

---

# ACT I — THE FALL
*Day 0 … Day 18. Everything stripped away in real time. The player learns the fugitive loop: investigate, act, puzzle, consequence. Tone: vertigo — the system is not malfunctioning; it is functioning, for someone else.*

### A1-S01 — "Intake"

- **ID / Title:** A1-S01 — "Intake"
- **Location:** [LOC-courthouse](LOCATIONS.md#loc-courthouse) — Justice center (booking & remand)
- **Time / Mood:** Day 1 — cold, procedural vertigo; strip-lit
- **Characters present:** CH-adam (Adam Vale); on TV: CH-hale (Marcus Hale)
- **What happens:** Booking and remand, staged as procedure-as-violence: fingerprints, flash photo, property bag holding a wedding ring. The charges are read aloud — 46 counts — and the player gets the document-reading tutorial on the charge sheet itself: buried in the RICO thicket, **Count 31: falsification of hydrological field data, 2018–2020** (**C-11** — why would a *fraud* case care so precisely about field-data dates? The question is available from hour one). On the dayroom TV, DA Marcus Hale's press conference: "the author of the largest environmental-data fraud in state history." *Author.* The word does a lot of work in this story (RH-07 begins its slow build: Hale fronting the case invites the inner-circle misread). Key shots: Count 31 highlighted under the player's cursor; Hale mid-sentence on a bolted-down TV; Adam's reflection ghosted on the screen over the word AUTHOR.
- **Player objective:** Survive intake; examine the charge sheet (document-reading tutorial — find Count 31).
- **How it starts:** Direct cut from the A0-S08 perp walk.
- **How it ends:** Remanded to holding; his public defender's note — proffer meeting, Day 4 — carries into A1-S02.
- **Links:** prev A0-S08 / next A1-S02.

### A1-S02 — "The Offer"

- **ID / Title:** A1-S02 — "The Offer"
- **Location:** [LOC-courthouse](LOCATIONS.md#loc-courthouse) — Justice center (proffer room)
- **Time / Mood:** Day 4 — pressure, disbelief; a small room made smaller
- **Characters present:** CH-adam (Adam Vale), CH-hale (Marcus Hale); unregistered: federal liaison, Adam's public defender
- **What happens:** Hale, flanked by a federal liaison, slides the plea across the table: 30 months, minimum security, in exchange for allocution — sworn confession to falsifying TS-19/44 *and associated field data* — plus named accomplices ("we can help you remember names"). This is the frame's kill-shot (the legal weapon that would poison the record by its own author's oath), and the scene must radiate how *reasonable* it is. Adam, still believing this is a fixable clerical catastrophe: "The data is real. Test the water." Hale, without blinking: "We did. It's clean." — true, because the Nightingale is running; the frame is nested inside the cover-up. Adam refuses. Walking out, his overwhelmed public defender mutters the act's quiet thesis: "I've never seen a case build itself like this" (**C-13** — literal description: the case *was* built, then fed). Key shots: the allocution's date range in close-up, matching Count 31; Hale's unblinking "It's clean."
- **Player objective:** Mixed — dialogue scene; the player can probe every option, but refusal is the canonical, authored exit (the game lets you *feel* the plea's gravity, not sign it).
- **How it starts:** Escorted from holding on Day 4.
- **How it ends:** Plea refused; bail hearing pending — hands to A1-S03.
- **Links:** prev A1-S01 / next A1-S03.

### A1-S03 — "Anonymous Grace"

- **ID / Title:** A1-S03 — "Anonymous Grace"
- **Location:** [LOC-courthouse](LOCATIONS.md#loc-courthouse) — Justice center (steps)
- **Time / Mood:** Day 6, grey glare after rain — vertigo, exposure
- **Characters present:** CH-adam (Adam Vale), CH-whitlock (Det. Sgt. Dana Whitlock, observing); unregistered: media scrum
- **What happens:** Bail is posted — by a surety Adam's own lawyer has never heard of: **Fidelis Surety** (**C-12**; an Aegis cutout — the Vestry *wants* him loose once the plea stalls, because flight is public confession and a fugitive can be authored freely). Release into a first-person media scrum: microphones as weapons, strangers shouting his name like an accusation, his own face on every screen in every window. From an unmarked car, Whitlock watches, already annoyed at her own case: defendants like this don't make bail — *who wants him out?* (her skepticism seeded here, one scene into her existence). Key shots: the bail receipt's unfamiliar letterhead; the scrum played in first person, lenses inches from the camera; Whitlock's still face in the wing mirror as the noise passes her by.
- **Player objective:** Push through the scrum to the car (first-person traversal under sensory assault); examine the bail paperwork.
- **How it starts:** Bail processed off-screen after A1-S02; pickup at the property window.
- **How it ends:** Adam is driven home to a street full of news vans — continuous into A1-S04.
- **Links:** prev A1-S02 / next A1-S04.

### A1-S04 — "House of Glass"

- **ID / Title:** A1-S04 — "House of Glass"
- **Location:** [LOC-vale-rowhouse](LOCATIONS.md#loc-vale-rowhouse) — The Vale rowhouse, under siege
- **Time / Mood:** Days 6–9, grey daylight through drawn curtains — suffocating
- **Characters present:** CH-adam (Adam Vale), CH-mara (Mara Vale)
- **What happens:** Interactive domestic collapse — the act's centerpiece of systemic violence, played as errands: the termination call from MWA (license suspended pending); accounts frozen mid-grocery-order (civil forfeiture, in a checkout UI); the mortgage called — the note held, the letterhead says, by **Meridian Trust** (the conspiracy touching the kitchen table, unremarked). On TV, the evidence drip: the offshore ledger graphic (the public debut of the fabricated money trail — the ledger that carries **C-27**, its single flaw findable in the case-file reader from Act II), "sources describe a longtime mistress, 'Violet M.'" (**C-35** begins its detonation sequence), and — between the scandal segments, unremarked — a health-desk item: Meridian Trust patriarch **Konstantin Voss**, gravely ill, stepping back from public life (**C-32**'s frailty plant, played as filler news). Mara holds through all of it — jaw set, loyal, terrifyingly quiet. Key shots: the DECLINED overlay on a grocery cart; Meridian Trust's letterhead in macro; Mara watching the "Violet M." chyron with a face the player cannot read.
- **Player objective:** Navigate the collapsing household — take the calls, attempt the errands, read every document; the mechanics are ordinary life failing one system at a time.
- **How it starts:** Arriving home from A1-S03 through the news vans.
- **How it ends:** Night, Day 9: Mara at the kitchen table with three documents squared in front of her — hard cut into A1-S05.
- **Links:** prev A1-S03 / next A1-S05.

### A1-S05 — "Everything, In Order"

- **ID / Title:** A1-S05 — "Everything, In Order"
- **Location:** [LOC-vale-rowhouse](LOCATIONS.md#loc-vale-rowhouse) — The Vale rowhouse (kitchen)
- **Time / Mood:** Day 9, evening — devastation; the rain very loud
- **Characters present:** CH-adam (Adam Vale), CH-mara (Mara Vale)
- **What happens:** The frame detonates its marriage charge. Mara has three documents lined up like a firing squad: the second phone "found" in the garage with two years of texts to *Violet Marsh*; an offshore account bearing *her* forged signature; and the badge log placing Adam at Records on the night of their cabin weekend — the one night he has no witness but her, and she was asleep (**C-07** payoff #1). She asks one question: "Why was your badge at Records on the 14th?" He has no answer. (Theo does.) Her clinic's funding is "under review" unless she cooperates; the protective order is drafted *for* her by a helpful advisor she'll never see again — and she signs, and leaves (**RH-03** planted: to Adam and the player, demolition is indistinguishable from betrayal; the debunking facts — the backwards E, the phone's impossible purchase date — already exist in-world, waiting for A3-S15). The house is empty and the rain is very loud. Key shots: the three documents in overhead tableau; the backwards-E signature on screen for one honest second; the door closing without a slam.
- **Player objective:** Cutscene/non-interactive.
- **How it starts:** Hard cut from the end of A1-S04 — the kitchen table, night.
- **How it ends:** Adam alone in the emptied house; the only thread he can pull is Theo — cut to A1-S06.
- **Links:** prev A1-S04 / next A1-S06.

### A1-S06 — "Theo's Silence"

- **ID / Title:** A1-S06 — "Theo's Silence"
- **Location:** [LOC-betting-cafe](LOCATIONS.md#loc-betting-cafe) — The betting café
- **Time / Mood:** Days 10–13, flat daylight — desperate, guilty, over-loud
- **Characters present:** CH-adam (Adam Vale), CH-theo (Theo Vale)
- **What happens:** Adam finds Theo at the betting café and confronts him about the badge night. Theo lies badly, over-laughs, presses cash on him ("for the lawyers") — and cries in the bathroom with the taps running, a sound the mix should not quite bury. The scene's design is dramatic irony as level design: player-findable in the café are fresh betting slips *paid off* and a burner phone with exactly one saved number. Adam cannot make himself see what it means; the player can, and the gap between them is the scene (Theo's behavioral collapse is the fair-play texture that has been running since A0-S06). Key shots: the paid-off slips fanned under a beer glass; the burner's single contact; the bathroom door and the running taps.
- **Player objective:** Confront Theo (dialogue); optionally search the café and journal the slips and burner.
- **How it starts:** From the empty house after A1-S05 — Adam goes looking for the one person who might explain the badge.
- **How it ends:** Nothing resolved; Theo's cash unspent in Adam's pocket; return to the siege house — into A1-S07.
- **Links:** prev A1-S05 / next A1-S07.

### A1-S07 — "The Second Wave"

- **ID / Title:** A1-S07 — "The Second Wave"
- **Location:** [LOC-vale-rowhouse](LOCATIONS.md#loc-vale-rowhouse) — The Vale rowhouse, night
- **Time / Mood:** Days 14–17, night — dread, then strange grace
- **Characters present:** CH-adam (Adam Vale); on TV: CH-skerry (Emil Skerry); remote: CH-cordell (Raymond Cordell, as ROOK9)
- **What happens:** The second wave of "evidence" breaks: a broker, **Emil Skerry**, is on every channel claiming Adam recruited him to shop fabricated contamination data to short-sellers (**RH-08** planted — the rented witness, positioned as the case's human foundation). Word comes that bail revocation and re-arrest are imminent. Then the game's strangest grace: Adam's dormant chess app pings — a move played in a two-year-dead correspondence game, from a new account, **ROOK9**, with a note in the annotation field: *"They come at 6 AM. Marsh Gate is unwatched from 4:40. Take nothing with a battery. Keep the notebook habit."* (**C-14** — the corpus begins; the storyboard must sell the idiom, the specificity, the *care*.) Adam burns an hour deciding whether it's a trap, and the player decides with him — packing is the interaction: what do you take when you can take nothing with a battery? Key shots: Skerry's practiced TV grief; the chess notification blooming on a dark phone; notebook #42 going into a coat pocket.
- **Player objective:** Read the tip; choose what to carry; commit to running (the decision beat is playable deliberation, not a menu).
- **How it starts:** Return from A1-S06 into the Skerry news cycle.
- **How it ends:** Pre-dawn, Day 18: engines in the street *before* 6 AM — the raid is early. Smash into A1-S08.
- **Links:** prev A1-S06 / next A1-S08.

### A1-S08 — "The Run"

- **ID / Title:** A1-S08 — "The Run" — SETPIECE
- **Location:** [LOC-lowmarsh](LOCATIONS.md#loc-lowmarsh) — Lowmarsh street level *(sec: [LOC-vale-rowhouse](LOCATIONS.md#loc-vale-rowhouse) exit, [LOC-marsh-gate](LOCATIONS.md#loc-marsh-gate) descent, [LOC-undercroft](LOCATIONS.md#loc-undercroft) tunnels)*
- **Time / Mood:** Day 18, 5:55 AM, swelling storm — chase, terror, the river rising
- **Characters present:** CH-adam (Adam Vale), CH-kray (Odile Kray — voice and boat-hook at the end)
- **What happens:** The raid comes early and the first true evasion setpiece detonates: out the back, over fences, through the yards and alleys of a waking Lowmarsh — dogs, clotheslines, a bakery's first light — with drones overhead, spotlights walling streets, and the storm swelling the river. The route funnels to the Marsh Gate steps, and Adam descends *under the WHEN THE RAIN RUNS PURPLE graffiti* (C-02 as literal signage for the fall into Hell) into the storm tunnels. The water takes him: a near-drowning sequence played to blackout — tumbled, slammed, lungs burning — ended by a grate, a boat-hook, and a woman's voice out of the dark: "Toll's a story. Start talking." Key shots: the 5:55 clock vs. the tip's "6 AM"; the graffiti overhead as Adam drops below street level; the drowning blackout with the surface light receding; the boat-hook silhouette.
- **Player objective:** Escape the raid — traverse, hide, and outrun the cordon; reach Marsh Gate; survive the tunnels (scripted near-drowning).
- **How it starts:** Engines at 5:55 AM interrupt A1-S07's final beat; the tip's timing was true but the enemy moved early.
- **How it ends:** Blackout in the water; consciousness returns on Kray's boat — direct into A1-S09.
- **Links:** prev A1-S07 / next A1-S09.

### A1-S09 — "Below"

- **ID / Title:** A1-S09 — "Below"
- **Location:** [LOC-lantern](LOCATIONS.md#loc-lantern) — The Lantern *(sec: [LOC-undercroft](LOCATIONS.md#loc-undercroft) — Kray's boat route in)*
- **Time / Mood:** Night, below; lamplight on black water — chthonic refuge
- **Characters present:** CH-adam (Adam Vale), CH-kray (Odile Kray), CH-verger (The Verger — Ezra Fenn)
- **What happens:** Kray ferries the half-drowned fugitive through the drowned streets — a sunken chapel passing beneath the hull, cellar windows glowing underwater — while Adam pays the stated toll: a story, his, told in pieces (the player's dialogue choices shape what he admits). She deposits him at the Lantern's door, where the first diegetic riddle waits — simple, teachable, the Verger's filter for cops and fools — and the player solves it to be let in. Inside: heat, soup, no questions, and the Verger's three rules: *"No paper. No questions. No one knows where anyone sleeps."* Stripped of everything document-shaped, Adam opens notebook #42 and writes his name, just to see it. Above, through a storm grate, his own wanted bulletin echoes off the wet brick. **End of Act I.** Key shots: the sunken chapel under the boat; the door riddle by lamplight; the name, handwritten, filling the frame.
- **Player objective:** Mixed — tell Kray the toll-story (dialogue); solve the Lantern door riddle.
- **How it starts:** Waking on Kray's boat after the A1-S08 blackout.
- **How it ends:** Admitted; fed; the wanted bulletin overhead as the act closes. Act break to A2-S01.
- **Links:** prev A1-S08 / next A2-S01. Act break: end of Act I.

---

# ACT II — HELL
*Day 18 … ~Week 14. Rock bottom: the discarded people, the darkest jobs, the deepest layer. Adam becomes capable — and risks becoming what they said he was. Contains the story's midpoint (A2-S07/S08). Tone: chthonic, strangely warm at the core; hell has better people than the surface.*

### A2-S01 — "The Rules of Below"

- **ID / Title:** A2-S01 — "The Rules of Below"
- **Location:** [LOC-lantern](LOCATIONS.md#loc-lantern) — The Lantern
- **Time / Mood:** Weeks 3–4, timeless dark — wary, strangely warm
- **Characters present:** CH-adam (Adam Vale), CH-nine (Felix "Nine" Novak), CH-verger (The Verger — Ezra Fenn)
- **What happens:** Lantern orientation: the Undercroft runs on an economy of favors, and the hub's quest grammar is established — everything below costs a favor; every favor is a mission. Introductions: **Nine**, forger and fixer, instantly likable ("Papers make the man, friend. Luckily I make papers"), and the Verger, who studies Adam a long moment too long. On the shelter wall, half-hidden behind hung oilskins, a brand-scar symbol the player can examine but not yet read — Adam will later learn it is **the Vestry's mark** (**RH-04** planted: the player's first reason to distrust the one man who deserves trust). The scene seeds the hub the game will live in until the finale: the soup line, the favor board, the future war-room corner. Key shots: Nine's card-trick handshake; the Verger's held gaze; the brand symbol in shallow focus.
- **Player objective:** Learn the hub and favor economy; take the first job from the favor board.
- **How it starts:** Morning-after (such as morning is, below) from A1-S09.
- **How it ends:** First favor accepted — the pharmacy run — hands to A2-S02.
- **Links:** prev A1-S09 / next A2-S02.

### A2-S02 — "First Job — The Pharmacy Run"

- **ID / Title:** A2-S02 — "First Job — The Pharmacy Run"
- **Location:** [LOC-depot](LOCATIONS.md#loc-depot) — Medical distribution depot
- **Time / Mood:** Night, sodium light and rain on corrugated roofs — tense, morally warm
- **Characters present:** CH-adam (Adam Vale); unregistered: Aegis depot guards
- **What happens:** Crime of necessity #1: the Lantern's insulin and antibiotics come from "shrinkage" at a distribution depot, and this month's contact got caught — so Adam goes. Full stealth-infiltration tutorial: patrol reading, light and sound, lock-picking. The depot's security contractor is **Aegis Meridian** — first sight of the logo that will chase him all game; even charity's leakage is their business. Adam crosses the line — picks the lock, takes the crate — and the worst part is how *good* he is at it, and how right it feels: hell's crimes feed people (first tone-setting moral note). In the depot office, liftable freight paperwork references Pier District redevelopment schemes (**RH-02** texture — the "wrong building" misdirection begins accumulating in the hauls). Key shots: the Aegis logo stencil under a work light; the crate of insulin in Adam's arms framed like stolen treasure; his ungloved competence on the lock.
- **Player objective:** Infiltrate the depot, steal the medical crate, exfiltrate unseen (stealth tutorial).
- **How it starts:** Favor accepted at the A2-S01 board; Kray drops him within walking distance of the surface target.
- **How it ends:** Crate exfiltrated clean; the medicine travels below to the Lantern's clinic shelf, and word of the new man's hands travels ahead of it — into A2-S03, where Nine is waiting with a proposition.
- **Links:** prev A2-S01 / next A2-S03.

### A2-S03 — "The Name Trade"

- **ID / Title:** A2-S03 — "The Name Trade"
- **Location:** [LOC-undercroft](LOCATIONS.md#loc-undercroft) — The Undercroft, deep tunnels
- **Time / Mood:** Timeless deep dark, water-noise everywhere — awe, dread
- **Characters present:** CH-adam (Adam Vale), CH-nine (Felix "Nine" Novak)
- **What happens:** Nine's price for a clean identity is not money — it's *competence*: the Undercroft's gravity-fed water feed is fouling, and word is the new man reads water. The first full-depth hydraulics puzzle (valve network, contamination isolation — the game's core puzzle grammar at maturity) deliberately routes Adam through the deep tunnels where he sees it with his own eyes: **violet leachate, live, sheeting down a Works-era wall** (**R0 begins**; **C-02** payoff #1 — the folklore is running in real time). Old habit outlives the old life: he takes a sample, labels it, logs it in #42. The player feels the story's floor shift — this was never just about him. Key shots: the valve wheel giving way after decades; the violet sheet crossing the torch beam (the game's first true image of the title); the sample vial held against the dark.
- **Player objective:** Repair the Undercroft water feed (valve-network / contamination-isolation puzzle); earn the clean identity.
- **How it starts:** Nine's proposition opens the scene — he has seen the pharmacy run land and names his price for clean papers: not money, competence — then leads Adam down to the fouling feed.
- **How it ends:** Feed restored; sample logged; papers promised — but the districts Adam now needs require passage, and passage means Kray: into A2-S04.
- **Links:** prev A2-S02 / next A2-S04.

### A2-S04 — "The Ferrywoman's Price"

- **ID / Title:** A2-S04 — "The Ferrywoman's Price"
- **Location:** [LOC-undercroft](LOCATIONS.md#loc-undercroft) — Kray's waters
- **Time / Mood:** On black water, lantern astern — transactional, cryptic
- **Characters present:** CH-adam (Adam Vale), CH-kray (Odile Kray)
- **What happens:** Passage negotiation aboard the Ferrywoman's boat — a scene of pure economy, hers: routes priced in favors, freight, and futures; nothing volunteered; nothing free. Her tunnel map is magnificent — decades of soundings, hand-corrected — and it has one blank quarter. Asked, she says only: *"No one ferries to the Vats. Toll's too high."* (The blank on the map is the game's second map-edge marker, and it points exactly where the finale must go.) Then, unprompted, watching Nine's lantern recede across the water, her one free gift: **"Rat swims close to the boat, engineer."** (**C-15** — the earliest Nine clue.) She won't elaborate; wildcards don't. Key shots: the map unrolled across the thwarts, blank quarter centered; Nine's distant light doubled in the black water under the line.
- **Player objective:** Mixed — negotiate district passage (dialogue/barter over the map).
- **How it starts:** Nine's papers need routes to matter; Adam hails the Ferrywoman from the Lantern dock.
- **How it ends:** Passage secured to the districts that matter; the Verger's stack of old bylines points to the next ally — into A2-S05.
- **Links:** prev A2-S03 / next A2-S05.

### A2-S05 — "Iris"

- **ID / Title:** A2-S05 — "Iris"
- **Location:** [LOC-duval-flat](LOCATIONS.md#loc-duval-flat) — Duval's flat
- **Time / Mood:** Day, shuttered light through blinds — paranoid, electric
- **Characters present:** CH-adam (Adam Vale), CH-duval (Iris Duval)
- **What happens:** The Verger keeps old bylines, and one name recurs on the true stories nobody believed: Duval. Adam finds her in a locked-down flat above a shuttered print shop — paranoid, brilliant, half-feral — behind three locks and a camera she checks twice. Her crazy wall (interactive, examinable) is 60% noise and 40% dead accurate; in the middle of it: the 2020 spiked story, a photo of **Coby Anders**, drowned, and the phrase written and circled — *"They don't kill stories. They kill authors."* (**C-16** — the game's method statement, hanging on a crank's wall.) Then the scene turns: her surviving fragment of the 2020 leak is a data table Adam *recognizes* — his own numbers, his own study. The leak that destroyed her came from TS-19/44. Guilt bomb; alliance forged in shared shrapnel. She teaches him the playbook's shape: he is its second edition. Key shots: the wall in slow pan, noise resolving into signal; Anders' photo under red string; Adam's hand on his own numbers in her handwriting-annotated fragment.
- **Player objective:** Mixed — earn Duval's trust (dialogue under her rules); examine the wall; connect the 2020 fragment to TS-19/44.
- **How it starts:** Kray-passage to the surface flat, address from the Verger's bylines.
- **How it ends:** Alliance formed; Duval starts pulling the finance thread. Back below, a chess ping is waiting — into A2-S06.
- **Links:** prev A2-S04 / next A2-S06.

### A2-S06 — "Rook's Second Gift"

- **ID / Title:** A2-S06 — "Rook's Second Gift"
- **Location:** [LOC-lantern](LOCATIONS.md#loc-lantern) — The Lantern
- **Time / Mood:** Small hours, lamp oil low — urgency, misplaced gratitude
- **Characters present:** CH-adam (Adam Vale); remote: CH-cordell (Raymond Cordell, as ROOK9)
- **What happens:** ROOK9 plays another move; the annotation reads: *County Archive Annex, Bay 9. Purge order Friday. TS-19/44 original, microfiche, custody logs, the notebooks they seized — all scheduled for the shredder. After Friday you were never right.* The mission designs itself — and that sentence is the design warning: the player should feel gratitude toward Rook here, because that is the trap working (the choreography's opening move; nothing on screen contradicts the guardian-angel read). Planning montage: Nine sources the Annex floor plans, Kray commits to a water exfil, Adam sets the clock. Among the reference papers in the planning spread, more Pier District redevelopment references drift through the haul (**RH-02** texture continues). Key shots: the annotation glowing on the phone in the dark; floor plans weighted with shell casings and soup mugs; Friday circled.
- **Player objective:** Cutscene/non-interactive (planning montage with examinable board before departure).
- **How it starts:** The chess ping waiting after A2-S05.
- **How it ends:** Plan set, night chosen — hard cut to the Annex fence: A2-S07.
- **Links:** prev A2-S05 / next A2-S07.

### A2-S07 — "The Archive Heist" — MIDPOINT

- **ID / Title:** A2-S07 — "The Archive Heist" — MIDPOINT SETPIECE
- **Location:** [LOC-archive-annex](LOCATIONS.md#loc-archive-annex) — County Archive Annex, Bay 9 *(sec: [LOC-undercroft](LOCATIONS.md#loc-undercroft) — boat exfil)*
- **Time / Mood:** Week 8, night — thrilling, and "too clean"
- **Characters present:** CH-adam (Adam Vale), CH-kray (Odile Kray, exfil); support remote: CH-nine (Felix "Nine" Novak, comms/plans)
- **What happens:** Night infiltration of the records warehouse — the game's midpoint setpiece, and its most important lie. It goes *almost* suspiciously well, and every oddity is visible to a careful player and explicable to a trusting one (**C-17**): a skeleton guard roster on a purge week; Bay 9's box already staged near the loading dock; its evidence seal *already broken*; and an alarm that only trips on *exit* — driving a thrilling, survivable boat-chase escape through the flooding channels with Kray at the tiller. Adam comes away holding the original TS-19/44, raw data, custody fiche — and the raid's seized field notebooks, #29 among them (his own case archive, boxed for the shredder). First real victory; the music says so; **the music is lying** (the truth waits at A2-S09 and A4-S02 — the heist was staged *for* him, to taint the original's custody and manufacture the records-compromise order's cause). Key shots: the roster board with too few names; the pre-staged box in the forklift lane; the broken seal in insert; spotlights raking the water as Kray's boat threads the outfall.
- **Player objective:** Infiltrate the Annex, retrieve the Bay 9 box (original TS-19/44 + microfiche + custody logs + the seized notebooks), escape via the boat chase.
- **How it starts:** Hard cut from A2-S06's plan to the perimeter fence, Friday minus one.
- **How it ends:** Clean getaway; the haul spread on the Lantern's table in the small hours — continuous into A2-S08.
- **Links:** prev A2-S06 / next A2-S08.

### A2-S08 — "Reading the Water" — REVEAL R1

- **ID / Title:** A2-S08 — "Reading the Water" — R1
- **Location:** [LOC-lantern](LOCATIONS.md#loc-lantern) — The Lantern (evidence-board corner)
- **Time / Mood:** Week 8, small hours — revelation, chill
- **Characters present:** CH-adam (Adam Vale)
- **What happens:** Evidence-board mechanic debut: original vs. doctored archive copy vs. notebook #29 vs. the fresh tunnel sample, assembled by the player's own hands. The doctored Figure 12 uses the **Cordell shortcut** in its fabricated math (**C-06** payoff #1 — logged now as "whoever forged this was MWA-trained; that's the shortcut Ray teaches" — the knife hidden in plain sight). The revision block carries reviewer initials **H.G. — Harold Grady — dated fourteen months after Grady died** (**C-18**; floated for one beat as "so Grady's the forger?" — **RH-06** — and debunked in the same scene by his obituary: the "suspect" *is* the proof). Then the frame's geometry snaps into focus: the allocution dates (C-11), the CLEARWATER re-validation (C-03), the doctored archive (C-04), the too-convenient promotion (**C-28**, pinned to the board) — all pointing *backward*. **"They didn't frame me to blame me. They framed me to unwrite me."** (**R1**.) The question mutates: not *why me* — *what did I sign?* He knows what he signed; now he knows someone needs it unsigned. Key shots: the two Figure 12 curves overlaid; the obituary date against the revision date; the board's strings converging on TS-19/44.
- **Player objective:** Assemble the evidence board (connection puzzle) to the R1 conclusion.
- **How it starts:** Continuous from A2-S07's return — the haul goes straight onto the table.
- **How it ends:** R1 stated aloud over the board; dawn above, and consequence already in motion — into A2-S09.
- **Links:** prev A2-S07 / next A2-S09.

### A2-S09 — "Heat"

- **ID / Title:** A2-S09 — "Heat"
- **Location:** [LOC-lantern](LOCATIONS.md#loc-lantern) — The Lantern *(sec: [LOC-undercroft](LOCATIONS.md#loc-undercroft) — the hit supply-drop site)*
- **Time / Mood:** Week 9 — consequence, paranoia
- **Characters present:** CH-adam (Adam Vale); suspicion montage: CH-duval (Iris Duval), CH-kray (Odile Kray), CH-nine (Felix "Nine" Novak)
- **What happens:** Consequence lands with both hands. News: *Fugitive engineer raids public archive; records integrity compromised* — and the state's response, an emergency **records-compromise order** authorizing "certified reconstruction of affected archives" by the Renewal's certification office. Cordell's office. Adam watches his victory become their permission slip in real time (partial comprehension now; the full horror is banked for A4-S02). And the Undercroft itself turns dangerous: an Aegis snatch squad hits a Lantern supply drop *Adam was scheduled for* — first hard proof that a leak exists. The suspicion montage is deliberately mis-aimed — Duval's recklessness? Kray's transactional soul? (**RH-01** planted) — while the honest data accumulates underneath: the near-misses touch only Nine-brokered movements (**C-21** pattern begins; mission-giver metadata is in the player's journal from here on). And one small, examinable wrongness in the aftermath: Nine turns up to the drop's post-mortem in a **new coat**, pouring **real coffee** — prosperity in a week when everyone else lost stock; the journal logs it as "good operator" texture (**C-20** begins its cumulative build). Key shots: the order's letterhead resolving to Cordell's office; the raided drop point, crates burst in the water; the new coat in shallow focus over the coffee pot; the three suspect faces in the montage — and Nine's, last, smiling.
- **Player objective:** Cutscene/non-interactive (journal gains the correlation data — and the C-20 texture note — afterward).
- **How it starts:** Morning after A2-S08 — the news reaches the Lantern with the bread.
- **How it ends:** The evidence board stands assembled in the Lantern's open hall, TS-19/44 and the violet sample pinned in plain sight; what the Verger makes of it opens A2-S10.
- **Links:** prev A2-S08 / next A2-S10.

### A2-S10 — "The Vestry Surfaces"

- **ID / Title:** A2-S10 — "The Vestry Surfaces"
- **Location:** [LOC-st-albans](LOCATIONS.md#loc-st-albans) — St. Alban's drowned chapel *(sec: [LOC-lantern](LOCATIONS.md#loc-lantern) — the board-viewing beat, scene top)*
- **Time / Mood:** Week 10, night, drowned nave by lamplight — liturgical, confessional
- **Characters present:** CH-adam (Adam Vale), CH-verger (The Verger — Ezra Fenn)
- **What happens:** At the Lantern, scene top: the Verger sees TS-19/44 and the violet sample on Adam's board — and stops pretending not to know things; he leads Adam by boat to St. Alban's. In the dark of the drowned chapel — hymn board frozen mid-century, water lapping the pew tops — the Verger tells it all: the 1989 deathbed confession of Works foreman Uriah Bell; his own attempt to raise it inside the Vestry; the manufactured charges, the defrocking, the exile — and the brand on his arm, *given*, not worn (**RH-04 debunked**: the mark is a wound, not a membership). Then the education begins: the Vestry, the Quiet Covenant of 1974, the cipher habit — *"the city is the ledger; learn to read it."* His history names names, and one recurs like a watermark: **the Voss family** — Aldous's line, the Works' founders, the dye money under the Trust, the name on the institute, on the plaques, on everything — the Vestry's founding blood, its dying patriarch still alive on Cathedral Hill (**RH-05 planted**: the player is invited to aim the whole conspiracy at Konstantin Voss). First true Vestry puzzle: the chapel's hymn-board numbers (frozen since 1968) key a dedication-plaque cipher, yielding a 1974 covenant fragment and a word: **the Nightingale service** (**C-19** thread opens). En route, **RH-02 is debunked**: the Pier District papers from the hauls point at a decoy — the water permits never touch the Pier; every hydrological thread drains toward the Vats. Key shots: the brand shown by lamplight; hymn numbers 1968-stuck; the decoded word NIGHTINGALE appearing letter by letter in Adam's notebook.
- **Player objective:** Mixed — hear the confession (dialogue); solve the hymn-board / dedication-plaque cipher (the Vestry puzzle family's true debut).
- **How it starts:** At the Lantern, the morning after A2-S09's aftermath settles, the Verger studies the standing board — then leads Adam by boat to St. Alban's.
- **How it ends:** A name in hand and a direction: the Vats. Kray won't ferry the last quarter-mile — into A2-S11.
- **Links:** prev A2-S09 / next A2-S11.

### A2-S11 — "Nightingale" — R0 COMPLETES

- **ID / Title:** A2-S11 — "Nightingale" — R0 COMPLETES
- **Location:** [LOC-nightingale-hall](LOCATIONS.md#loc-nightingale-hall) — The Nightingale pump hall & the Vats
- **Time / Mood:** Week 11, night — horror-adjacent awe; machine-noise in a drowned dark
- **Characters present:** CH-adam (Adam Vale); unregistered: Nightingale night crew (near-miss)
- **What happens:** With Kray paid in future favors — she still won't ferry the last quarter-mile; he wades it, chest-deep, torch in his teeth — Adam reaches the edge of the Vats and finds the impossible: a **cathedral-sized Victorian pump hall, running.** Maintained machinery, greased rails, violet slick in the sump, fresh bootprints, a clipboard on a nail. The conspiracy is not a cover-up; it is an *operating utility with a maintenance schedule* (**R0 completes** — the folklore, the leachate, and now the machine that hides them). He photographs everything and lifts the maintenance log: contractor of record, **Larkspur Facility Services** (**C-19**). Then the horror-adjacent setpiece: the night crew arrives, and Adam hides *inside the machine that hides the crime* — pressed into the pump housing while boots ring past on the gallery. Key shots: the hall revealed in one rising crane shot from water level; the clipboard's mundane sign-off column; the hiding place inside the pump's service hatch, one bootstep from discovery.
- **Player objective:** Infiltrate the pump hall, photograph the machinery and sump, lift the Larkspur log, evade the night crew, and get out.
- **How it starts:** From A2-S10's decoded word — Kray-passage to the map's blank edge, then the wade.
- **How it ends:** Out with photographs and the log; the return below into a changed Undercroft — into A2-S12.
- **Links:** prev A2-S10 / next A2-S12.

### A2-S12 — "What They Say I Am"

- **ID / Title:** A2-S12 — "What They Say I Am"
- **Location:** [LOC-undercroft](LOCATIONS.md#loc-undercroft) — The Undercroft at large
- **Time / Mood:** Week 12 — hunted, self-doubting; the tunnels colder
- **Characters present:** CH-adam (Adam Vale); news: CH-skerry (Emil Skerry, dead)
- **What happens:** The Vestry escalates — off-screen, the kill decision is made over Cordell's objection (per §4.4 of STORY.md), visible to the player only as a change in weather: Aegis stops trying to *catch* him. Broker **Emil Skerry** is found dead, and the murder is authored onto Adam within a news cycle (**RH-08**'s true function revealed in hindsight: the witness was always disposable; his death is a twofer — silence the liability, blacken the fugitive). A records warehouse burns; that's Adam's too, says the ticker. A bounty is posted *below* — even Undercroft eyes change; the Lantern's soup line goes quiet when he passes. And one fact sits examinable amid the burn: as route after route and stash after stash is hit through the bounty era, **Nine's shop alone is never raided** — the journal logs it beside the new coat (**C-20** texture accumulating; readable now as luck, damning at A3-S11). Low point of the act: Adam catches his own face on a dayroom-style TV over the word KILLER, then in a wet black window — and catches himself checking whether the face fits. Key shots: Skerry's covered gurney on the news; bounty chalk-marks appearing on tunnel walls; the reflection shot, held.
- **Player objective:** Cutscene/non-interactive.
- **How it starts:** The news cycle catching up to A2-S11's return.
- **How it ends:** With the world above and below both closing, Kray makes the real offer — into A2-S13.
- **Links:** prev A2-S11 / next A2-S13.

### A2-S13 — "The Choice in the Dark"

- **ID / Title:** A2-S13 — "The Choice in the Dark"
- **Location:** [LOC-undercroft](LOCATIONS.md#loc-undercroft) — the meet site, low tunnels *(floodwater rising)*
- **Time / Mood:** Week 13, night, floodwater — chaos, heartbreak
- **Characters present:** CH-adam (Adam Vale), CH-kray (Odile Kray), CH-theo (Theo Vale); unregistered: Aegis wire team
- **What happens:** Kray, evenhanded as gravity, makes the real offer: out. Tonight. Clean papers, a coastal boat, a life — the option that would end the game as a tragedy the world never learns to name. This is the formal **commitment beat** (tracked, not scored): the player sits with the offer, and refusing it defines Adam. Then Marr's trap springs — a meet brokered "from Theo," and it *is* Theo: wired, terrified, weeping, Aegis in the walls. Chaos setpiece under one inviolable design rule: **the game gives no mechanism to harm Theo.** In the collapse and floodwater escape, Theo's confession spills — the debts, the errands, **the badge** (**C-07** payoff #2) — "I didn't know it was for *you*, Adam, I swear, I didn't *ask*—" Because he couldn't afford to; Lowmarsh's oldest skill. Adam gets him out through the water and — canonical path — forgives him, which is worse than rage: Theo now owes a debt no one can carry (this forgiveness fires the A3-S08 tragedy). Key shots: Kray's offer laid out as two documents and a tide table; the wire glimpsed under Theo's soaked shirt; the brothers surfacing in the flooded dark, Theo's confession between breaths.
- **Player objective:** Face the commitment beat (refuse the way out — tracked choice); then escape the wire-trap with Theo through collapsing, flooding tunnels.
- **How it starts:** Kray's summons after A2-S12; the "Theo" meet request arrives mid-conversation.
- **How it ends:** Theo sent back up into the city with his forgiveness and his guilt; Adam returns to the Lantern resolved — into A2-S14.
- **Links:** prev A2-S12 / next A2-S14. Tracked choice: the commitment beat (canonical: refuse the out).

### A2-S14 — "Act Turn — Out of Hell"

- **ID / Title:** A2-S14 — "Act Turn — Out of Hell"
- **Location:** [LOC-lantern](LOCATIONS.md#loc-lantern) — The Lantern *(remote recipient: Whitlock, surface mail)*
- **Time / Mood:** Week 14 — resolve; the first still water of the game
- **Characters present:** CH-adam (Adam Vale), CH-verger (The Verger — Ezra Fenn); remote recipient: CH-whitlock (Det. Sgt. Dana Whitlock)
- **What happens:** Regrouping at the Lantern, Adam does something new with the H.G. anachronism (C-18): he *doesn't* spend it. He photographs it, keeps the original sealed and untouched, and mails the print anonymously to the one hunter whose paperwork-allergy he's clocked from news conferences: **Det. Dana Whitlock** — the act's learning made operational: *provenance is ammunition; fugitives can't fire it, but cops can.* Production note for the board dressing: among the documents pinned there sits a "smoking-gun" Vestry memo Adam never sourced firsthand (**C-25**, seeded off-screen by Nine on Marr's orders) — present, unremarked, provenance-less from the moment it appears; it must be visibly on the board from this scene so its A3-S07 detonation reads as the player's own oversight. The Verger's benediction over the evidence board closes the act: *"You've mapped hell. Now climb with the map."* **End of Act II.** Key shots: the print going into a plain envelope; the sealed original into the Verger's keeping; the board wide-shot with C-25 in plain, ignorable sight.
- **Player objective:** Cutscene/non-interactive (the mailing is authored; the board is examinable before it).
- **How it starts:** Return from A2-S13, the night's water still in Adam's clothes.
- **How it ends:** The envelope goes up with the morning's smuggled mail; the act turns — into A3-S01.
- **Links:** prev A2-S13 / next A3-S01. Act break: end of Act II.

---

# ACT III — PURGATORY
*~Week 14 … ~Week 29. The climb. Alliances built, reversals suffered, the leak found, the Rook unmasked. The act where Adam stops being prey. Tone: momentum with a limp; every gain pays a toll. Contains the story's LOW POINT (A3-S08) and the great REVERSAL (A3-S07).*

### A3-S01 — "The Ascent Plan"

- **ID / Title:** A3-S01 — "The Ascent Plan"
- **Location:** [LOC-lantern](LOCATIONS.md#loc-lantern) — The Lantern (war room)
- **Time / Mood:** Week 14–15, lamplight — momentum with a limp
- **Characters present:** CH-adam (Adam Vale), CH-duval (Iris Duval), CH-verger (The Verger — Ezra Fenn)
- **What happens:** War-room scene: the game's quest map goes diegetic — cork, string, stolen fiche, the evidence board grown into a campaign wall. Targets named: the deal's paper spine (escrow, indemnity, grant conditions) and the leak inside Adam's own life. At the wall's summit sits the crew's working theory of a mastermind, pinned in Duval's hand: **KONSTANTIN VOSS** — old money, old sin, the institute, the name on everything (**RH-05** build; the strings converge on him because the ledger-city keeps writing his family's name). Assignments split the act: **Duval takes finance**, **the Verger takes the ledger-city** (the Vestry's ciphered civic record), **Adam takes the Trust**. The C-25 memo remains pinned mid-board — the only document nobody can say where it came from, and nobody says so (fair-play staging: the camera passes it without comment). The scene's tone sets the act: these are no longer fugitives hiding, they are a crew *working*. Key shots: the wall in full for the first time; three hands taking three folders; rain heard but not seen — the surface is a destination again.
- **Player objective:** Cutscene/non-interactive (war-room board examinable; act's mission structure unlocked after).
- **How it starts:** The morning after A2-S14's mailing — the climb begins.
- **How it ends:** Missions assigned; the game cuts away from Adam for the first time — into A3-S02.
- **Links:** prev A2-S14 / next A3-S02.

### A3-S02 — "Whitlock Bites"

- **ID / Title:** A3-S02 — "Whitlock Bites"
- **Location:** [LOC-courthouse](LOCATIONS.md#loc-courthouse) — Justice center (task-force offices)
- **Time / Mood:** Daylight, institutional — quiet weapon loading
- **Characters present:** CH-whitlock (Det. Sgt. Dana Whitlock), CH-hale (Marcus Hale)
- **What happens:** Interleaved perspective — witnessed via Duval's courthouse source and news fragments; the design keeps Adam player-locked, so this plays as authored scene, not playable POV switch. Whitlock quietly verifies the H.G. anachronism from the anonymous print: the state's own document, initialed by a man fourteen months dead — checkable, checked, true. She pulls the Fidelis Surety thread (C-12) one shell deep, and it points toward Aegis — which retroactively makes the pre-op surveillance of A0-S07 legible (C-08's payoff track begins). Then **Hale kills her requests in writing** — obstruction, on the record, filed away without a word (the paper that convicts him of usefulness at A4-S09; RH-07's build continues: is he inner circle, or something smaller?). She goes quiet. Quiet, in Whitlock, is a weapon being loaded. Key shots: the print unfolded beside the obituary; the denial memo's signature block; her case-file drawer — a second, private folder starting.
- **Player objective:** Cutscene/non-interactive (interleaved perspective).
- **How it starts:** Cut from A3-S01's assignments to the surface, days later — the mailed print landing.
- **How it ends:** Her private folder closes on the Fidelis paper; cut back below to the gala prep — into A3-S03.
- **Links:** prev A3-S01 / next A3-S03.

### A3-S03 — "The Trust Job" — SETPIECE

- **ID / Title:** A3-S03 — "The Trust Job" — SETPIECE
- **Location:** [LOC-meridian-trust](LOCATIONS.md#loc-meridian-trust) — Meridian Trust tower (gala floors; Kessler's private floor)
- **Time / Mood:** Week 16, evening gala — glittering, knife-edged
- **Characters present:** CH-adam (Adam Vale), CH-kessler (Vivian Kessler); support: CH-nine (Felix "Nine" Novak, forged invitation), CH-kray (Odile Kray, the suit & the exit); remote: CH-cordell (Raymond Cordell, as ROOK9)
- **What happens:** The Renewal's victory-lap fundraiser, and the game's social-stealth setpiece: Adam hidden in plain sight among people who only ever looked at his mugshot — forged invitation by Nine, suit from Kray's rag trade. At the fitting, Nine asks — concern wearing tailor's chalk — where Adam has been sleeping these days; Adam deflects; the journal logs the question (**C-20** completes its build: fortunes, immunity, and now target-development questions). Rook had warned, unusually: *"Gala's too hot. Abort."* Adam disobeys (**C-29** — the first Rook tip whose beneficiary is unclear: protecting Adam, or Kessler's floor? The ambiguity is the clue, and it primes the audit instinct). Two prizes from the private floor: the **indemnity annex** (all pre-transfer environmental liability capped and assigned to the public side) and the **escrow schedule** — subsidiary acquisitions including three remediation contractors (**C-22**), and one line item, absurd until it isn't: *"fountain & waterscape maintenance — $3.1M/yr — Larkspur Facility Services"* (**C-34** — Nightingale's budget wearing a landscaping skin). And the scene the act is remembered for: **Kessler catches him at the champagne table — recognizes him — and talks.** Two minutes, everything true, nothing helpful: "You're looking for the man who decided. Keep looking. There hasn't been one since before I was born." She lets him leave (a panicked fugitive arrested at her gala is a headline; a doomed one is a Tuesday). Aegis arrives *fast* anyway — too fast; the job was Nine-brokered (**C-21** ticks again). Key shots: the invitation scanning green; the $3.1M line under Adam's pocket camera; Kessler's toast-glass pause of recognition; blue Aegis light in the marble lobby as the service exit closes.
- **Player objective:** Infiltrate the gala (social stealth); reach Kessler's private floor; photograph/steal the indemnity annex and escrow schedule; exfiltrate ahead of Aegis.
- **How it starts:** From A3-S02's cutaway back to the crew: invitation ready, gala tonight; Rook's abort warning arrives as Adam dresses.
- **How it ends:** Out by the service canal with both documents; the haul goes to Duval — into A3-S04.
- **Links:** prev A3-S02 / next A3-S04.

### A3-S04 — "The Meaning of Money" — REVEAL R2

- **ID / Title:** A3-S04 — "The Meaning of Money" — R2
- **Location:** [LOC-lantern](LOCATIONS.md#loc-lantern) — The Lantern (war room)
- **Time / Mood:** Week 17 — inversion, despair
- **Characters present:** CH-adam (Adam Vale), CH-duval (Iris Duval)
- **What happens:** Duval decodes the gala haul, and the mid-game's premise inverts on screen: the indemnity annex assigns the poison's cost to the public *before* discovery; the trust owns the remediation contractors; the institute owns the discovery clock. She lays the three documents side by side and says the line the act is built on: **"They're not hiding the poison, Adam. They're farming it."** (**R2**.) The deal is not endangered by the truth coming out; the deal is a machine *for* the truth coming out — on their schedule, into their invoices. Then the despair beat, played quiet: exposure — the entire strategy so far — may be exactly what they're pricing in. Every well the truth could be poured into is one they own. Key shots: the three documents aligned like a proof; the string wall re-read in silence; Adam's marker hovering over "EXPOSE THEM" on the board and not writing it.
- **Player objective:** Cutscene/non-interactive (the decoded documents join the examinable board).
- **How it starts:** Duval's all-night decode after A3-S03's haul lands.
- **How it ends:** Strategy in doubt; then the Verger's oldest channel stirs — a hymn-board number changed at a chapel nobody attends — into A3-S05.
- **Links:** prev A3-S03 / next A3-S05.

### A3-S05 — "Voss's Summons"

- **ID / Title:** A3-S05 — "Voss's Summons"
- **Location:** [LOC-voss-house](LOCATIONS.md#loc-voss-house) — The Voss house, Cathedral Hill
- **Time / Mood:** Week 18, midnight — deathbed gothic; oxygen hiss and rain on tall glass
- **Characters present:** CH-adam (Adam Vale), CH-voss (Konstantin Voss); unregistered: the paid-deaf nurse; Aegis headlights at the end
- **What happens:** Through the Verger's oldest channel, the dying patriarch asks for the fugitive. Midnight in the mausoleum-house: oxygen hiss, a nurse paid to be deaf, a room where the century keeps its furniture. Konstantin Voss — bladder cancer, the dye-worker's disease, the same one that killed Gabriel Vale (**C-32** named on screen: poisoner and poisoned share a pathology) — wants... absolution? A witness? He speaks only in the Vestry's idiom, half-confession, half-riddle: *"Ask the window what the rain paid for."* (**C-23**) — and presses a watch-fob key into Adam's hand: "the family's memory is in the family's keeping; my granddaughter has the keeping of it." Aegis headlights sweep the drive; Adam goes through the garden. **Four days later Voss is dead** — "peacefully, in his sleep," ruled natural, timing immaculate; the game never resolves whether Kessler ordered it (deliberate ambiguity: the Vestry's mercy and its murder look identical, which *is* the reveal). **RH-05 begins its collapse:** the player has now met the "mastermind" and found a frightened old man. Key shots: the fob key pressed into a palm; the oxygen line hissing through the confession; headlights raking the ceiling; the four-days-later obituary insert.
- **Player objective:** Cutscene/non-interactive (garden escape as brief playable sting).
- **How it starts:** The changed hymn-board number at the end of A3-S04; Kray-passage up Cathedral Hill's storm drains.
- **How it ends:** A riddle and a key in hand; the window is the next stop — into A3-S06.
- **Links:** prev A3-S04 / next A3-S06.

### A3-S06 — "The Window"

- **ID / Title:** A3-S06 — "The Window"
- **Location:** [LOC-st-brigids](LOCATIONS.md#loc-st-brigids) — St. Brigid's church & free clinic
- **Time / Mood:** Week 19, night — sacred, wounding
- **Characters present:** CH-adam (Adam Vale), CH-verger (The Verger — Ezra Fenn)
- **What happens:** St. Brigid's by night, with the Verger. The violet window — *St. Brigid holding back a violet flood* — is read properly at last: the 1975 "restoration" donor panel is a payment cipher; the lancet inscriptions key to Concordance folios; the window is a **receipt, in glass, for the Quiet Covenant**, installed in the one building Lowmarsh would never tear down (**C-24**; **C-33** payoff — the truth stood witness over Adam's whole life, unread). Continuity of Vestry knowledge, 1974 onward, becomes *provable* — if anything the Verger holds could ever be believed; his hollowed look at that sentence is the scene's second wound. The first is free of charge: framed on the sacristy wall among the parish's local couples, a wedding photo — Adam and Mara, ten years younger, laughing — the violet flood rising in glass behind them the entire time. Key shots: torchlight climbing the window panel by panel as the cipher resolves; donor names becoming ledger lines; the wedding photo found without music.
- **Player objective:** Mixed — decode the window (donor-panel payment cipher with the Verger's folio keys).
- **How it starts:** Voss's riddle (C-23) aimed here; the Verger unlocks the church he was once sacristan of.
- **How it ends:** The receipt decoded and photographed; above, Duval's patience is running out — into A3-S07.
- **Links:** prev A3-S05 / next A3-S07.

### A3-S07 — "Duval's Gun Jumps" — THE REVERSAL

- **ID / Title:** A3-S07 — "Duval's Gun Jumps" — THE REVERSAL
- **Location:** [LOC-duval-flat](LOCATIONS.md#loc-duval-flat) — Duval's flat
- **Time / Mood:** Week 20 — triumph curdling to ash inside 48 hours
- **Characters present:** CH-adam (Adam Vale), CH-duval (Iris Duval)
- **What happens:** Against the plan — her byline hunger, her six starved years — Iris publishes: *THE VATS ARE LEAKING*, with the rescued TS-19/44 as centerpiece... and, unknowingly, the seeded "smoking-gun" Vestry memo that Nine slipped into Adam's stash on Marr's orders weeks ago (**C-25** detonates — in retrospect flagged as the only document on the board Adam never sourced firsthand; Duval: "it was too good; God, it was too good"). The Vestry's response is 48 hours of surgical grace: the memo exposed as a forgery (it is one), carbon-dated, mocked; therefore *everything* published presumed forged; TS-19/44 publicly welded to a proven fake; "the fugitive's disinformation network" becomes the story of record. Third demonstration of the well-poisoning playbook (Duval 2020; the compromise order; now this) — the player finally sees the *pattern as the villain*. All documentary leverage: ash. One true word survives in print, unnoticed by everyone but the story: *nightingale* (**C-30** planted in the wreckage). Duval, on the floor of her flat, surrounded by her life's second ruin: "I handed them the match." Key shots: the headline going live; the debunk montage in broadcast-graphics language; the burned-out board; the word *nightingale* on newsprint, in shallow focus, unremarked.
- **Player objective:** Cutscene/non-interactive.
- **How it starts:** Duval's byline goes up while Adam is still photographing the window — he arrives at the flat inside the 48-hour debunk.
- **How it ends:** Leverage gone, allies broken — and the worst is queued: Theo has seen what the story needed — into A3-S08.
- **Links:** prev A3-S06 / next A3-S08.

### A3-S08 — "Theo" — THE LOW POINT

- **ID / Title:** A3-S08 — "Theo" — THE LOW POINT
- **Location:** [LOC-squat](LOCATIONS.md#loc-squat) — The squat
- **Time / Mood:** Week 21 — the darkest hour; indifferent rain
- **Characters present:** CH-adam (Adam Vale); dead: CH-theo (Theo Vale)
- **What happens:** Theo, carrying the unpayable debt of A2-S13's forgiveness, tries to fix it alone: he approaches the disgraced Duval with the one thing that could resurrect her story — his own taped confession about the badge. Marr's cleanup is faster. **Theo dies in a supervised-looking squat: staged overdose, needle in his arm.** The city shrugs — junkie brother of a fraud. Adam is brought to the scene by the Undercroft's grapevine, and knows in one breath that it's murder — *Theo fainted at needles* (**C-26** payoff: the A0-S06 flu-shot joke detonates six acts of sorrow) — and knows in the second breath that forgiving Theo is what killed him: absolution sent him looking for penance. The game's darkest hour. The rain does not care; the scene's design withholds music, mercy, and interactivity alike. Key shots: the room staged *almost* right — and the needle, wrong forever; Adam not touching anything, engineer's discipline as grief; the rain on the skylight, even, endless.
- **Player objective:** Cutscene/non-interactive.
- **How it starts:** Word reaches the Lantern within hours of A3-S07's collapse.
- **How it ends:** A body to bury and nothing else — into A3-S09.
- **Links:** prev A3-S07 / next A3-S09.

### A3-S09 — "The Funeral"

- **ID / Title:** A3-S09 — "The Funeral"
- **Location:** [LOC-cemetery](LOCATIONS.md#loc-cemetery) — The cemetery (Theo's grave)
- **Time / Mood:** Week 21 + 3 days, wet daylight — cold, sorrowful
- **Characters present:** CH-adam (Adam Vale, disguised), CH-marr (Silas Marr), CH-mara (Mara Vale)
- **What happens:** Theo's burial, minimal, wet. Adam attends disguised inside a gravedigger's crew — **and Marr lets him**, which is the scene: the hunter appears beside him at the treeline, gun holstered, voice even, and delivers the antagonist thesis graveside: *"Order isn't clean, Mr. Vale. It's maintained. You maintained water; I maintain arrangements. You'd have understood each other, our jobs."* He offers the last courtesy — leave tonight, the city forgets you in a year — and walks away, confident as weather. This is the villain's peak: he is never more ahead than now, and never again. Across the grave: **Mara** — who does not look at Adam, and leaves her clinic pin on Theo's headstone. It is not for Theo (Theo teased her about that pin; she'd never part with it idly). It is a signal flare with a pin backing: *I've started counting my dead differently* (**RH-03** begins its debunk). Key shots: two men at a treeline talking over a grave like colleagues; the pin placed on wet granite in close-up; Mara's departure without a glance — and Adam understanding the pin anyway.
- **Player objective:** Cutscene/non-interactive.
- **How it starts:** Three days after A3-S08; the crew disguise arranged below.
- **How it ends:** Grief needs a target; Nine's channels are already coughing one up — into A3-S10.
- **Links:** prev A3-S08 / next A3-S10.

### A3-S10 — "Rage" — PLAYER-CHOICE VALVE

- **ID / Title:** A3-S10 — "Rage" — PLAYER-CHOICE VALVE
- **Location:** [LOC-transit-yard](LOCATIONS.md#loc-transit-yard) — The transit yard
- **Time / Mood:** Week 22, rain-flooded night — fury reined
- **Characters present:** CH-adam (Adam Vale), CH-krebs (Lt. Dane Krebs)
- **What happens:** Nine's channels cough up the cleanup detail: **Lt. Dane Krebs**, Aegis, handled Theo. Adam hunts him through a rain-flooded transit yard — a pursuit level built of dead rolling stock, hissing third rails, and knee-deep water — and corners him against a flooded cut. The game opens its first formal choice valve, tracked but never moralized: **kill him / flip him / walk away.** Canonical: Adam, at the edge, hears his own creed come back in Cordell's voice — *the data doesn't lie* — and takes evidence over blood: Krebs's phone and geotagged Aegis field notes. On every path the player exits holding that evidence (the valve prices the man, not the case): the notes make the interception pattern undeniable (**C-21** payoff) — every Aegis near-miss correlates with Nine-brokered jobs. Only Nine's. Key shots: the hunt's final corner, Krebs lit by a dying signal lamp; the choice held in silence, no UI flourish; the geotag map scrolling — pin after pin after pin, all Nine.
- **Player objective:** Hunt and corner Krebs; make the valve choice (kill / flip / walk away — tracked, epilogue-shading); secure the phone and field notes.
- **How it starts:** Nine's intel at the end of A3-S09's grief; the hunt is player-initiated the moment the name lands.
- **How it ends:** All branches converge: evidence in hand, the leak has a shape, and the shape is Nine — into A3-S11.
- **Links:** prev A3-S09 / next A3-S11. **Choice valve (tracked):** kill / flip / walk away; canonical = evidence over blood. All branches converge on A3-S11; the choice shades character reactions and epilogue text.

### A3-S11 — "The Rat"

- **ID / Title:** A3-S11 — "The Rat"
- **Location:** [LOC-forge-shop](LOCATIONS.md#loc-forge-shop) — Nine's forge-shop *(sec: [LOC-undercroft](LOCATIONS.md#loc-undercroft) — the barge burn, dawn)*
- **Time / Mood:** Week 23 — sorrowful, then dawn fire
- **Characters present:** CH-adam (Adam Vale), CH-nine (Felix "Nine" Novak), CH-kray (Odile Kray)
- **What happens:** Confrontation at the forge-shop, played sorrowful, not shouting: Adam lays out the correlation like a proof — the geotags (C-21), the upticks in Nine's fortune after every near-miss (**C-20**, retro-flagged), the questions about where Adam sleeps, the fact that Nine is never, ever raided. Nine folds — and the mechanism is worse than betrayal: **his sister**, in state custody, her safety a dial Marr turns. "You'd have done the same." "Maybe. You'll do different now." (**RH-01 debunked** in the same stroke: the pattern never touched Duval-only information.) Adam flips him — triple agent — and the first counterfeed goes upward immediately: a false safehouse location. At dawn, Aegis burns an empty barge. The barge was Kray's — *volunteered* — and the sight of Aegis torching her property does what no cause could: **the Ferrywoman is in**, her price stated flatly: "the Vats toll. Someone's finally going to pay it." One clean week begins — the first silence in Adam's head since the raid. Key shots: the proof laid out on the forge bench, document by document; Nine's hands going still over his tools; the barge burning on black water at dawn, Kray watching with an accountant's face.
- **Player objective:** Mixed — conduct the confrontation (dialogue-driven, evidence presented from the journal); authorize the false-safehouse counterfeed.
- **How it starts:** Straight from A3-S10's geotag evidence — the walk to the forge-shop is the fuse.
- **How it ends:** Nine controlled, Kray committed; exactly one unaudited channel remains — into A3-S12.
- **Links:** prev A3-S10 / next A3-S12.

### A3-S12 — "Canary Trap" — REVEAL R3

- **ID / Title:** A3-S12 — "Canary Trap" — R3
- **Location:** [LOC-lantern](LOCATIONS.md#loc-lantern) — The Lantern *(sec: unnamed surface church + meet sites — deliberately unregistered locations)*
- **Time / Mood:** Week 24 — checkmate by mail; very quiet
- **Characters present:** CH-adam (Adam Vale), CH-verger (The Verger — Ezra Fenn); remote: CH-cordell (Raymond Cordell, as ROOK9)
- **What happens:** With Nine controlled, exactly one leak remains: the channel Adam never audited because it only ever *gave*. He runs a canary trap — three meets, three channels, each fed a different location; ROOK9 alone gets the church option. **Aegis hits the church.** The proof sits on the board like a checkmate delivered by mail — and then the corpus analysis lands the name the player has been invited to dread (C-05, C-06, C-09, C-10, C-11, C-14, C-29, C-35 converging): engineering idiom; allocution dates matching one supervision window; a warrant that knew the notebooks *and the count*; forged math using a taught shortcut; a persona named with a cipher-keeper's vanity; and *castle early, castle often* — an opening habit reproduced across nineteen ROOK9 games. **Rook is Ray Cordell.** (**R3**.) Flashback stitch: A0-S05's expensive nothing, replayed with sound on. Adam does not rage. He goes very, very quiet, and asks the Verger for one clean suit. Key shots: three envelopes, three couriers; the church raid on a stringer's long-lens feed; the corpus board assembling line by line to one name; the flashback insert of Cordell's face at lunch, now legible.
- **Player objective:** Mixed — design and dispatch the canary trap (choose the three channels' baits); assemble the corpus-analysis proof on the board.
- **How it starts:** The audit instinct, finally aimed at the channel that only ever gave — the morning after A3-S11's clean week begins.
- **How it ends:** The name known; a clean suit requested; a lake cabin at the end of a long drive — into A3-S13.
- **Links:** prev A3-S11 / next A3-S13.

### A3-S13 — "One Last Game"

- **ID / Title:** A3-S13 — "One Last Game"
- **Location:** [LOC-cordell-cabin](LOCATIONS.md#loc-cordell-cabin) — Cordell's lake cabin
- **Time / Mood:** Week 25, day, lakeside — intimate, glacial
- **Characters present:** CH-adam (Adam Vale), CH-cordell (Raymond Cordell)
- **What happens:** The scene the whole script protects. Adam arrives as the student — no accusation, no wire, one chessboard. Two old men's rituals performed perfectly by two liars: whiskey poured, weather discussed, a game played. Cordell — warm, funny, *paternal*, and (the audience now knows) the architect — offers, unprompted, escape money and a door: "If you ever stop running, there's a way out of the city that doesn't end in a courtroom. Old men keep doors." (The same door. His door. **R4 pre-echo** — played on the player's incomplete knowledge: they know *who*, not yet *why-him*.) Adam declines with a smile, and — the scene's only weapon — **castles late**, breaking the habit Cordell installed. Says nothing. Leaves. Cordell sits alone with the board and reads the move for what it is; his hand is not quite steady clearing the pieces. Both men now know, and neither has said a word: the hunt is finally honest — and from this beat forward, **Adam is ahead for the first time** (Nine flipped, Rook burned, choreography exposed: the antagonist-advantage inversion completes). Key shots: the whiskey pour matched to two decades of muscle memory; the late castle in insert, held; Cordell alone with the board, one piece rattling faintly as he sets it down.
- **Player objective:** Mixed — play the cabin game (chess interaction + dialogue under a mask); the late castle is the player's own deliberate input.
- **How it starts:** The clean suit and the long drive after A3-S12; Adam goes knowing, Cordell receives suspecting.
- **How it ends:** The unsaid mutual knowledge; drive back in silence; salvage work waiting — into A3-S14.
- **Links:** prev A3-S12 / next A3-S14.

### A3-S14 — "Lena"

- **ID / Title:** A3-S14 — "Lena"
- **Location:** [LOC-lantern](LOCATIONS.md#loc-lantern) — The Lantern
- **Time / Mood:** Week 27 — salvage, new steel
- **Characters present:** CH-adam (Adam Vale), CH-lena (Lena Voss), CH-duval (Iris Duval)
- **What happens:** Fallout salvage: one true detail in Duval's burned story — the word *nightingale* — matched a phrase in a 1974 letter **Lena Voss** found in her dead grandfather's papers (**C-30** payoff: the failed story functioning, structurally, as the beacon that finds the last ally; every defeat in this act seeds its own answer). She reaches out through Duval and arrives below: forensic hydrologist, Voss face, Lowmarsh anger. The watch-fob key (C-23) finds its lock — a family archive strongbox — and yields letters, 1968–1975, in Aldous-line hands, discussing the Covenant in the domestic plural. **Clean provenance the frame never mapped.** Her terms, stated like lab protocol: "The name confesses. It doesn't settle." And one cold datum Duval logs from the surface papers as the letters are read: in the weeks since Konstantin's death, **nothing has slowed** — the Trust's timetable has, if anything, accelerated (**RH-05's debunk completes**: the decapitation test fails on screen; the war-room's mastermind card comes down, because the engine was never the dying man — it was the money and the method). Key shots: the newsprint word and the letter phrase side by side; the fob key turning; letters unfolded with gloved hands — evidence handling as family reckoning.
- **Player objective:** Cutscene/non-interactive (the letters join the examinable board).
- **How it starts:** Duval, sifting her own wreckage after A3-S13, finds the one true word — and the stranger it summoned.
- **How it ends:** The provenance lattice has its second clean strand; the third is chalked on a cemetery gate — into A3-S15.
- **Links:** prev A3-S13 / next A3-S15.

### A3-S15 — "Mara's Ledger"

- **ID / Title:** A3-S15 — "Mara's Ledger"
- **Location:** [LOC-st-brigids](LOCATIONS.md#loc-st-brigids) — St. Brigid's free clinic, night ward *(sec: [LOC-cemetery](LOCATIONS.md#loc-cemetery) — the gate signal)*
- **Time / Mood:** Week 28, night-ward hush — guarded, piercing
- **Characters present:** CH-adam (Adam Vale), CH-mara (Mara Vale)
- **What happens:** The pin answered: a chalked clinic symbol at the cemetery gate — her channel, her tradecraft, learned alone. One meeting, a night ward, whispering between cribs. Mara has rebuilt the cluster map from twenty years of triage ledgers — onset dates, addresses, the 2014 inflection (**C-01** payoff; independently corroborating the institute's secret study, and folding C-32's pathology into evidence). She has also, quietly, verified the Violet Marsh phone predates its own "purchase" — her own frame-crack, found unprompted: she never needed him to be innocent on faith; she needed data; she is, after all, the person he married. No reconciliation — withheld deliberately: "This isn't for you. It's for them." And at the door, not turning: "The signature on that account was traced from our mortgage. I sign my E backwards. They didn't know that. You did." *She knows.* (**RH-03 fully debunked** — for the player, before Adam dares believe it.) Key shots: the chalk symbol by torchlight; the cluster map unrolled between cribs, addresses clustering the Flats; the backwards E, finally explained; her exit line delivered to the door, not to him.
- **Player objective:** Cutscene/non-interactive.
- **How it starts:** The chalked answer to the pin, days after A3-S14.
- **How it ends:** Every strand is now on the board — and the board is insufficient, which is the next scene's premise — into A3-S16.
- **Links:** prev A3-S14 / next A3-S16.

### A3-S16 — "The Plan" — ACT TURN

- **ID / Title:** A3-S16 — "The Plan" — ACT TURN
- **Location:** [LOC-lantern](LOCATIONS.md#loc-lantern) — The Lantern *(sec: [LOC-st-albans](LOCATIONS.md#loc-st-albans) — the drowned chapel's edge, final image)*
- **Time / Mood:** Week 29, nine days out — heist-movie resolve
- **Characters present:** CH-adam (Adam Vale), CH-verger (The Verger — Ezra Fenn), CH-duval (Iris Duval), CH-kray (Odile Kray), CH-nine (Felix "Nine" Novak), CH-lena (Lena Voss)
- **What happens:** Everything is on the board; the board is insufficient — that is the plan's premise. Documentary war is lost *by design* (R2 + A3-S07 proved it): the Vestry owns every well the truth could be poured into. The Verger says the operative line over the wreckage of the paper strategy: **"Paper burns. Water remembers."** The strategy inverts — stop testifying; **demonstrate**. The vote is in nine days, inside a broadcast ritual the deal itself invented (first-draw certification sampling — C-03's ceremony clause becomes the plan's doorway); Storm **Vesper** is inbound off the coast, upgraded twice; the Nightingale is a machine, machines have load limits, and Adam Vale is the best water engineer this city ever trained. Heist-movie planning grammar: roles assigned around the table (executed as A4-S01's prep suite). Final image of the act: Adam at the drowned chapel's edge, notebook #42 open to a fresh page, writing the plan's first line — *Make the water testify.* **End of Act III.** Key shots: the paper strategy literally set aside in a crate; the storm track chart over the ceremony schedule; the fresh page, the four words.
- **Player objective:** Mixed — participate in the planning (role-assignment interaction; full board review); the act turn is authored.
- **How it starts:** All strands home after A3-S15; the crew convened in full for the first time.
- **How it ends:** Nine days on the clock — into A4-S01.
- **Links:** prev A3-S15 / next A4-S01. Act break: end of Act III.

---

# ACT IV — RECKONING
*~Week 29 … Week 31, plus epilogue. Judgment: the name cleared publicly, revenge in the measure the player chooses, the machine stopped. Tone: convergent — every act's debts called in. The storm and the vote arrive together, because the Vestry scheduled the vote and God scheduled the storm, and only one of them can be lobbied.*

### A4-S01 — "Nine Days"

- **ID / Title:** A4-S01 — "Nine Days"
- **Location:** [LOC-lantern](LOCATIONS.md#loc-lantern) — The Lantern (staging hub) *(sec: [LOC-ag-office](LOCATIONS.md#loc-ag-office) — the AG's office; [LOC-undercroft](LOCATIONS.md#loc-undercroft) — the Vats route; [LOC-forge-shop](LOCATIONS.md#loc-forge-shop) — the credentials)*
- **Time / Mood:** Days −9 … −1, rising storm — convergent purpose
- **Characters present:** CH-adam (Adam Vale), CH-whitlock (Det. Sgt. Dana Whitlock), CH-chen (Dr. Amara Chen), CH-kray (Odile Kray), CH-verger (The Verger — Ezra Fenn), CH-lena (Lena Voss), CH-duval (Iris Duval), CH-nine (Felix "Nine" Novak)
- **What happens:** The prep-mission suite, interleaved across five threads as Vesper's cone tightens on the coast — three playable by Adam, two witnessed from his world (Adam is player-locked; GAMEPLAY.md §8.2). **The Sampler:** Whitlock's file (H.G. + Fidelis + Hale's obstruction paper) finally walks into the State Attorney General's office — producing not an arrest but the needed inch: **Dr. Amara Chen**, State Water Board, will personally conduct the ceremony's first-draw certification sampling, with sealed duplicates; Kessler cannot object to compliance theater without breaking her own script (her ritual, hijacked — the plan's central irony). **The Route:** Kray runs the Vats approach — the toll finally paid in the coin she always meant: *witness*. **The Ledger:** the Verger surfaces the Concordance from its forty-year hide — a coffin-shaped waterproof case, because of course it is. **The Letters:** Lena and Duval authenticate the family archive; Duval's formal authentication pass also lands the frame's one technical flaw — the backdated "2023" wire in a 2024-only interbank format (**C-27**, findable in the case-file reader since Act II, now formally found) — and she preps the *real* story under the vow that defines her arc: **it runs second.** Truth first, byline after. **The Lie:** Nine's last forgery, for the good guys this time — the credentials that put Adam's people inside the ceremony's service perimeter. Key shots: the AG's inch granted in one signature; Kray's soundings of the Vats channel; the coffin-case opened; the wire anomaly circled in red; credentials fanned like a winning hand.
- **Player objective:** Complete the prep-mission suite — five interleaved threads: three playable (the Route, the Letters, the Lie) and two witnessed (the Sampler, the Ledger); ready the ceremony operation.
- **How it starts:** Directly from A3-S16's role assignments — day −9 begins on a checklist.
- **How it ends:** One lock remains before the storm: the crypt beneath St. Alban's — into A4-S02.
- **Links:** prev A3-S16 / next A4-S02.

### A4-S02 — "The Concordance" — REVEAL R4

- **ID / Title:** A4-S02 — "The Concordance" — R4
- **Location:** [LOC-vestry-crypt](LOCATIONS.md#loc-vestry-crypt) — The Vestry crypt, beneath St. Alban's
- **Time / Mood:** Night (days −3 … −2), flooded crypt — silent but for water
- **Characters present:** CH-adam (Adam Vale), CH-verger (The Verger — Ezra Fenn)
- **What happens:** The drowned Vestry crypt — the club's first hall, flooded since 1968 — and the game's final riddle gauntlet: hymn-cipher, ledger-stones, and the watch-fob key's **twin lock** (Voss's key + the Verger's memory — the two exiles' halves united; thematically load-bearing: only the discarded, together, can open the ledger). Inside: the **Concordance** — cipher-minutes 1877–1974, the Quiet Covenant vote itself — and appended in a younger hand the Verger never had the heart to show anyone, the routing copy of **Cordell's 1988 certification**, annotated by the Quorum's then-secretary: *"The young man signed. He will be of use for thirty years."* (**R4** — the First Lie, and the full answer to *why Adam*: TS-19/44 would have unspooled to 1988; the mentor authored the student's erasure to keep his own from surfacing. **"You weren't framed for what you'd do. You were framed for what he did."**) Filed with the Covenant's operational annexes: the archive-heist choreography memo — staged box, exit-only alarm, the compromise order pre-drafted *before* the break-in (**C-17** payoff; **R3's full stitch**). The player's proudest win, A2-S07, is re-graded before their eyes into the enemy's move. The room is silent except for water. Key shots: the twin lock turning in two hands; the 1988 certificate's annotation in a dead secretary's copperplate; the choreography memo laid over the player's own heist map, matching beat for beat.
- **Player objective:** Solve the crypt gauntlet (hymn-cipher + ledger-stones + twin lock); recover the Concordance and its annexes.
- **How it starts:** The last prep thread of A4-S01 — the Verger leads Adam down through the chapel he showed him in A2-S10.
- **How it ends:** The *why* complete, the ledger recovered — and Nine's masterpiece arrives the same night — into A4-S03.
- **Links:** prev A4-S01 / next A4-S03.

### A4-S03 — "Marr's File" — R5 ARMED

- **ID / Title:** A4-S03 — "Marr's File" — R5 ARMED
- **Location:** [LOC-lantern](LOCATIONS.md#loc-lantern) — The Lantern *(sec: [LOC-aegis-vault](LOCATIONS.md#loc-aegis-vault) — Nine's extraction, off-screen; remote recipient: Marr)*
- **Time / Mood:** Small hours, day −2 — the coldest, cleanest beat in the game
- **Characters present:** CH-adam (Adam Vale), CH-nine (Felix "Nine" Novak); remote recipient: CH-marr (Silas Marr)
- **What happens:** Nine's triple-cross delivers his masterpiece: from Aegis's own contingency vault, the Vestry's succession-and-containment dossier — post-vote cleanup protocols, and the designated author of all crimes should the arrangement ever surface: **MARR, S.** The fixer himself, pre-framed by his own employers — evidence pre-staged, a Skerry-style witness pre-retained (**C-31**; the playbook's next edition, already typeset — the system always needs an author). Adam reads it twice and does the coldest, cleanest thing in the game: **mails it to Marr.** No note. No ask. Just the ledger, shown to the man whose name is newly in it. (Chekhov's fixer, cocked — **R5 armed**; it fires at A4-S06.) Key shots: the dossier tab with Marr's name, plain type; Adam reading it twice, timing the second read; the envelope, addressed in block capitals, going into the surface mail; Nine watching Adam do it, and understanding him completely for the first time.
- **Player objective:** Cutscene/non-interactive.
- **How it starts:** Nine's extraction lands (off-screen at LOC-aegis-vault) the night of A4-S02's return.
- **How it ends:** The weapon mailed; nothing left to prepare — one evening remains — into A4-S04.
- **Links:** prev A4-S02 / next A4-S04.

### A4-S04 — "Eve of Vesper"

- **ID / Title:** A4-S04 — "Eve of Vesper"
- **Location:** [LOC-lantern](LOCATIONS.md#loc-lantern) — The Lantern *(sec: [LOC-st-albans](LOCATIONS.md#loc-st-albans) — the flooded chapel steps)*
- **Time / Mood:** Day −1, eve of the storm, lamplight — tender, held breath
- **Characters present:** CH-adam (Adam Vale), CH-mara (Mara Vale), CH-verger (The Verger — Ezra Fenn), CH-duval (Iris Duval), CH-kray (Odile Kray), CH-nine (Felix "Nine" Novak), CH-lena (Lena Voss)
- **What happens:** The quiet-before scene, earned: the Lantern, all of them, soup and lamplight — the crew that hell assembled eating together on the eve of the climb's last pitch. The Verger's benediction, version two: *"For the drowned and the discarded — stand up."* And one honest conversation, Adam and Mara, alone on the flooded chapel steps — no reconciliation offered or asked, only the terms of a future: **"Come back out of this one alive, and we'll see who you are then. I'd like to meet him."** Rain begins as she says it. It does not stop for three scenes. Key shots: the long table in lamplight, every face the game has earned; the benediction with bowed and unbowed heads alike; two figures small on the chapel steps as the first squall line crosses the water; the rain arriving like a held note beginning.
- **Player objective:** Cutscene/non-interactive.
- **How it starts:** The evening after A4-S03 — nothing left to do but eat, and say it.
- **How it ends:** Vesper's leading edge over the city; dawn is Day V — into A4-S05.
- **Links:** prev A4-S03 / next A4-S05.

### A4-S05 — "Ratification Day" — FINALE BEGINS

- **ID / Title:** A4-S05 — "Ratification Day" — FINALE BEGINS
- **Location:** [LOC-ascension-plaza](LOCATIONS.md#loc-ascension-plaza) — Ascension Plaza & the Waterworks Cathedral *(sec: [LOC-undercroft](LOCATIONS.md#loc-undercroft) — boat staging; [LOC-nightingale-hall](LOCATIONS.md#loc-nightingale-hall) — the descent)*
- **Time / Mood:** Day V (early November, ≈ Week 30), the hundred-year storm making landfall — convergent thunder
- **Characters present:** CH-adam (Adam Vale), CH-lena (Lena Voss), CH-whitlock (Det. Sgt. Dana Whitlock), CH-chen (Dr. Amara Chen), CH-kray (Odile Kray), CH-verger (The Verger — Ezra Fenn), CH-duval (Iris Duval), CH-deane (Mayor Portia Deane), CH-hale (Marcus Hale), CH-kessler (Vivian Kessler)
- **What happens:** Ascension Plaza, the renovated Waterworks Cathedral — the old pump station made a secular temple, the Vestry's aesthetic self-portrait purchased with public money. The livestreamed vote begins as Vesper arrives: Deane beaming; Hale on the dais rereading his own doubts; Kessler ascendant in grey. Their schedule assumed rain; nobody's assumed *this* — the city's hundred-year storm surging the river as the cameras go live. Cross-cut deployment of every ally: Whitlock and Dr. Chen at the sampling pavilion, credentials immaculate (Nine's best work); Kray's boats staged in the storm tunnels; the Verger with Duval, the Concordance and letters sealed and **withheld** — nothing publishes until the water speaks; discipline as doctrine now. And the playable thread: Adam and Lena descending to the Nightingale hall through water already violet at the seams. Key shots: the broadcast clock and the storm-surge gauge intercut; Chen's credentials scanning green under Whitlock's flat gaze; the crew's boats idling in the dark like a held breath; violet threads curling through the descent water — the first hint the machine is already losing.
- **Player objective:** Mixed — play the descent thread (reach the Nightingale hall with Lena through flooding tunnels) while the deployment cross-cut carries the other stations.
- **How it starts:** Dawn, Day V — straight from A4-S04's first rainfall into the operation.
- **How it ends:** Adam and Lena at the hall doors as the broadcast goes live above — into A4-S06.
- **Links:** prev A4-S04 / next A4-S06.

### A4-S06 — "The Nightingale Falls" — SETPIECE + R5 PAYOFF

- **ID / Title:** A4-S06 — "The Nightingale Falls" — SETPIECE + R5 PAYOFF
- **Location:** [LOC-nightingale-hall](LOCATIONS.md#loc-nightingale-hall) — The Nightingale pump hall & the Vats
- **Time / Mood:** Day V, storm load, screaming machinery — cathartic, cold
- **Characters present:** CH-adam (Adam Vale), CH-lena (Lena Voss), CH-marr (Silas Marr); unregistered: Aegis crew
- **What happens:** The pump hall at storm load, screaming — the finale's setpiece and the design thesis fully expressed: Adam's masterstroke is an engineer's, not a saboteur's. He does not destroy the Nightingale — he **re-routes it**, valve by valve, junction by junction, a final full-grammar hydraulics puzzle under time pressure and rising floodwater — sending seventy years of intercepted leachate *to daylight*: the storm drains, the plaza's showcase fountain loop, the ceremonial first-draw main. The storm supplies the violence; Adam only opens the doors. Then Aegis's crew arrives — and behind them, **Marr**, file in hand, and the standoff the whole game has priced: he looks at the machine, the rising violet water, his own name in the Vestry's ledger (A4-S03's mail, received and believed — he is the one man professional enough to believe evidence about himself) — and gives the only order left that serves *order*: **"Contract's void. Fall back."** Aegis walks. The fixer takes his insurance archive and leaves his employers naked to the weather (**R5 payoff**). **Choice valve (tracked):** the player may refuse the standoff and fight him — the hall's flood mechanics make it the game's hardest encounter; canonically he walks, and it lands colder. Lena, at the junction wheel, gets the act's best quiet line: "Grandfather's money dug this. I'm just returning it." Key shots: the valve ballet against the load gauges; Marr reading the room like a ledger, then the order; the master junction opening — violet water leaving the hall *upward*, toward the cameras.
- **Player objective:** Solve the full-grammar re-route puzzle under storm load; then face the standoff valve (let Marr walk — canonical — or fight).
- **How it starts:** Through the hall doors from A4-S05, storm sirens above.
- **How it ends:** The re-route committed; the water goes up to testify — cut to the broadcast: A4-S07.
- **Links:** prev A4-S05 / next A4-S07. **Choice valve (tracked):** let Marr walk (canonical) / fight him. Both branches converge on A4-S07; the choice shades A4-S09's disposition of Marr (proffer and trial vs. death in the hall) and epilogue text.

### A4-S07 — "Purple Rain" — THE SCENE

- **ID / Title:** A4-S07 — "Purple Rain" — THE SCENE
- **Location:** [LOC-ascension-plaza](LOCATIONS.md#loc-ascension-plaza) — Ascension Plaza & the Waterworks Cathedral *(sec: [LOC-lowmarsh](LOCATIONS.md#loc-lowmarsh) — the streets running purple)*
- **Time / Mood:** Day V, storm peak — the sky testifies
- **Characters present:** CH-deane (Mayor Portia Deane), CH-chen (Dr. Amara Chen), CH-kessler (Vivian Kessler), CH-hale (Marcus Hale), CH-whitlock (Det. Sgt. Dana Whitlock), CH-duval (Iris Duval)
- **What happens:** Above, live, in one unbroken broadcast: the vote passes — applause — Deane raises the ceremonial first-draw glass as Vesper peaks — and the glass fills **faint violet**. A beat of pure broadcast silence. Then the plaza fountain erupts lavender; the storm drains backing up through Lowmarsh send the streets' floodwater running *purple downhill into the plaza*, sheeting around the stage; Dr. Chen — on camera, by the deal's own compliance script — draws, seals, and states for the record; a million phones film the sky and streets of Meridian raining violet over the Ascension. The folklore, the graffiti, the window, the title: paid off in a single image (C-02's final payoff; the C-01/C-24 lattice strands going public on schedule). Duval's story drops **second, as sworn**: the Concordance, the letters, the clinic map, TS-19/44 re-validated against live chemistry. **You cannot indict the rain.** Kessler does not run. She straightens her jacket, watches the water find its level, and starts making calls — which is scarier. Key shots: the glass filling violet in macro against the teleprompter's "clean water" copy; the fountain's first lavender pulse; the aerial of Lowmarsh running purple downhill; Chen's seal clicking shut; Kessler's jacket-straighten, held to the cut.
- **Player objective:** Cutscene/non-interactive.
- **How it starts:** Direct cut from A4-S06's opened junction to the broadcast feed.
- **How it ends:** The world knows — and one man is missing from the dais. Adam knows where he is — into A4-S08.
- **Links:** prev A4-S06 / next A4-S08.

### A4-S08 — "The Undercroft Door"

- **ID / Title:** A4-S08 — "The Undercroft Door"
- **Location:** [LOC-seal-chamber](LOCATIONS.md#loc-seal-chamber) — The 1988 seal chamber
- **Time / Mood:** Day V, storm night, rising violet water — elegiac reckoning
- **Characters present:** CH-adam (Adam Vale), CH-cordell (Raymond Cordell), CH-whitlock (Det. Sgt. Dana Whitlock, at the waterline)
- **What happens:** Cordell is not on the dais and was never going to be. Adam knows where he is because he knows him: down, at the beginning — the 1988 seal chamber by the old outfall, water rising past its cornerstone. Final confrontation, no boss bar: an old man, a chessboard set on a survey crate, and the game's whole argument in dialogue. Cordell's confession is self-justification with perfect engineering: one signature, then forty years of "maintenance"; the city's every honest pipe as amortization on a single lie. He offers Adam the last door — a prepared exit, money, silence, *"you of all people know the record can say anything"* — the temptation stated in the hero's own stolen creed. **Choice valve (tracked), the game's third:** **let the water take him / leave him to the flood he built / drag him out for trial.** Canonical: Adam hauls his mentor up through the rising violet dark and delivers him to Whitlock at the waterline with the game's title-fight line: **"You are what you sign. Sign this."** (The arrest report. He does.) Key shots: the chessboard on the crate, pieces already placed — one last game offered and declined; the cornerstone date going under; the haul up through violet water, two men's weight on one grip; the signature on the arrest report, unhurried, final.
- **Player objective:** Descend to the seal chamber; play the confrontation; make the valve choice (drown / abandon / save — tracked, epilogue-shading).
- **How it starts:** From A4-S07's broadcast — Adam leaves the victory to others and goes down alone.
- **How it ends:** Canonically, Cordell signed over to Whitlock at the waterline; all branches converge on the fallout — into A4-S09.
- **Links:** prev A4-S07 / next A4-S09. **Choice valve (tracked):** let the water take him / leave him to the flood / drag him out for trial (canonical). All branches converge on A4-S09; the choice shades the fallout's Cordell disposition and epilogue text.

### A4-S09 — "Fallout"

- **ID / Title:** A4-S09 — "Fallout"
- **Location:** [LOC-courthouse](LOCATIONS.md#loc-courthouse) — Justice center *(sec: [LOC-airfield](LOCATIONS.md#loc-airfield) — Kessler's arrest; [LOC-cemetery](LOCATIONS.md#loc-cemetery) — Theo's grave)*
- **Time / Mood:** Days V+1 … V+10, light rain — consequence working honestly
- **Characters present:** CH-adam (Adam Vale), CH-hale (Marcus Hale), CH-kessler (Vivian Kessler), CH-whitlock (Det. Sgt. Dana Whitlock); via archive material: CH-marr (Silas Marr's insurance archive — canonically alive; disposition per the A4-S06 valve); posthumous: CH-skerry (Emil Skerry's tapes)
- **What happens:** Days, compressed, documentary-style. An emergency injunction voids the transfer pre-closing; the State AG and federal validators descend. **Hale flips in seventy-two hours flat** — C-27, the impossible wire, gives him the door his self-preservation was scratching at ("I was fed a case. I can prove it, because I kept what they fed me"); his proffer buries Kessler and ends his own career as a footnote (**RH-07 debunked**: a consumer of the frame, never an author — the banality is the point). **Kessler is arrested at the airfield**, composed, lawyered — "You've mistaken me for the author. I'm only the accountant." — and convicted in the end not by any single document but by the **lattice**: Concordance + letters + clinic ledger + escrow trail + live sampling + Marr's insurance archive, arriving by courier, unsigned — every strand from a source the frame never thought to poison, because every strand came from someone the Vestry had already discarded (the theme, stated as a prosecution exhibit list). Charges against Adam: **dismissed with prejudice**; Skerry's posthumous "insurance" tapes of his own coaching sessions (**RH-08 debunked** — the witness was rented, the testimony scripted) and the Grady anachronism formally vacate the record-poisoning — TS-19/44 is re-certified, *his stamp restored by the same statute that voided it*. The exoneration press conference is held on the courthouse steps in light rain. **Adam does not attend.** He is at Theo's grave, reading the charges-dismissed order aloud, once, quietly, and leaving it under a stone — paper, finally, doing the only job it was ever good for: witness, not weapon. Key shots: the injunction stamp; Hale's proffer-room reversal in the same room as A1-S02; Kessler ducking into the car unbowed; the exhibit list scrolling — every source a discard; the order under the stone, rain dotting it.
- **Player objective:** Cutscene/non-interactive (documentary montage; the closing grave beat is the player's one slow walk).
- **How it starts:** Dawn after Day V — the machinery of consequence, uncorrupted for once, begins to turn.
- **How it ends:** The order under the stone; months pass — into A4-S10.
- **Links:** prev A4-S08 / next A4-S10. (Branch shading: Marr's disposition here reflects the A4-S06 valve — canonically trial with a proffer; Cordell's reflects A4-S08. He never apologizes for Theo. Some doors stay shut.)

### A4-S10 — "What Heaven Is Now" — EPILOGUE

- **ID / Title:** A4-S10 — "What Heaven Is Now" — EPILOGUE
- **Location:** [LOC-meridian-streets](LOCATIONS.md#loc-meridian-streets) — citywide montage *(sec: [LOC-nightingale-hall](LOCATIONS.md#loc-nightingale-hall) — remediation cranes; [LOC-lantern](LOCATIONS.md#loc-lantern); [LOC-st-albans](LOCATIONS.md#loc-st-albans) — the drained crypt; [LOC-waterworks](LOCATIONS.md#loc-waterworks) — the field office)*
- **Time / Mood:** ≈ V + 5 months, spring again, ordinary rain — a beginning
- **Characters present:** CH-adam (Adam Vale), CH-mara (Mara Vale), CH-verger (The Verger — Ezra Fenn), CH-kray (Odile Kray), CH-duval (Iris Duval), CH-whitlock (Det. Sgt. Dana Whitlock), CH-nine (Felix "Nine" Novak), CH-lena (Lena Voss); unregistered: the rookie engineer
- **What happens:** Months on, in ordinary rain. The consent decree; remediation cranes over the Vats — the contractors seized from Kessler's trust now operating under Lena's re-chartered **Voss Remediation Fund** (the dye money paying its bill at last). The Lantern, legal now, still run on three rules; the Verger declines his reinstatement — "I keep the door" — but is seen, once, sweeping St. Alban's drained crypt like a man who might someday hold a service. Kray's boats carry inspectors and schoolchildren, licensed, exorbitant. Duval's second story wins the prize her first one should have; she teaches now — sourcing, mostly. Whitlock runs the new public-integrity unit and remains professionally unimpressed by everyone. Nine, sentence suspended for cooperation, makes only legal documents and is bored beyond description; his sister walks free. And Adam — reinstated, older, new house on the *dry* side of nothing, because nowhere in Meridian is far from water and he wouldn't want it to be — meets Mara for coffee on a Saturday. It is not the old life; it is a first date, ten years and one apocalypse after the wedding. She laughs at something. Final beat, the creed closed: at the MWA field office, Adam hands a terrified new engineer a blank field notebook. *"The data doesn't lie."* Beat. *"People do. Write it down anyway."* Fade on Meridian in clean rain, the sky rinsed of everything but weather. (Epilogue text shades per the tracked choices: A2-S13, A3-S10, A4-S06, A4-S08.)
- **Player objective:** Cutscene/non-interactive (a single slow playable walk through the changed city may carry the montage; no fail states).
- **How it starts:** Time-skip from A4-S09's grave beat — "months later," spring rain.
- **How it ends:** Fade to credits. Optionally, after credits — A4-S11.
- **Links:** prev A4-S09 / next A4-S11 *(optional post-credit sting)*. Otherwise: end of game.

### A4-S11 — Post-credit sting *(optional)*

- **ID / Title:** A4-S11 — (Post-credit sting — optional; sequel/DLC hook; non-canonical-load-bearing)
- **Location:** [LOC-vestry-row](LOCATIONS.md#loc-vestry-row) — Vestry Row (the Vestry clubhouse, sealed correspondence room)
- **Time / Mood:** After — the rain elsewhere, presumably still ordinary
- **Characters present:** (none)
- **What happens:** The Vestry's correspondence room, sealed by court order — evidence tags on the shelves, dust sheets over the reading desks. On the evidence table, among the ciphered letter-books: outbound correspondence, decades of it, addressed to vestries, guilds, and "improvement societies" in **eleven other cities**. One envelope, recent, outgoing, unsent. The stamp is unfamiliar. The rain, somewhere else, is presumably still ordinary. For now. Key shots: a slow dolly down the letter-book shelves, city names accumulating; the unsent envelope centered on the table; the unfamiliar stamp in extreme close-up; cut to black on rain heard, not seen.
- **Player objective:** Cutscene/non-interactive.
- **How it starts:** Plays after the credits complete (optional; skippable; not load-bearing for canon).
- **How it ends:** Cut to black. End.
- **Links:** prev A4-S10 (after credits) / next — (end of game). Optional scene; sequel hook only.

---

*End of SCENES.md v1.0. Scene count: 58 (A0: 8, A1: 9, A2: 14, A3: 16, A4: 11). Any change to scene order, clue placement, or the choice valves must be reconciled against `../narrative/MYSTERY_LOGIC.md` (reveal graph §5, sequencing constraints) and `../narrative/TIMELINE.md` (§2 calendar) before it lands here.*
