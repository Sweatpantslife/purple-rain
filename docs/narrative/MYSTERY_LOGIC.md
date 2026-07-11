# PURPLE RAIN — Mystery Logic (v1.0)

> **The clue web.** Companion to [`STORY.md`](STORY.md) (scriptment) and [`TIMELINE.md`](TIMELINE.md) (true chronology). This document is the mystery's engineering drawing: every clue, where it is planted, what it appears to mean, what it really means, and where it pays off; every red herring and its debunk beat; the antagonist-advantage mechanics and their inversion points; the reveal dependency graph; and the fair-play and frame-mechanics audits.
>
> **Total spoilers.** Scene IDs (`A#-S##`), clue IDs (`C-##`), red herrings (`RH-##`), and reveals (`R0`–`R5`) as defined in STORY.md.
>
> **Design rules enforced here:**
> 1. Every identity/architecture reveal (**R1, R3, R4**) has at least three independent clues planted at least one act before it lands. **R0** (an experiential discovery) and **R2/R5** (document-discovery beats) are held to a lighter bar: their clue inputs precede them on the critical path (§5), with at least one seed planted an act early (C-01/C-02 for R0; C-03's grant framing plus R0's context for R2; the "someone must always sign" doctrine — Marr's graveside creed A3-S09, the Verger's exile story A2-S10 — for R5).
> 2. Every red herring has an explicit on-screen debunk.
> 3. No clue is *only* available in optional content; optional content may deepen a clue but the critical path plants it.
> 4. A first-time player should feel each reveal as a surprise; a second-time player should find every reveal fully seeded ("surprising, then inevitable").

---

## 1. Clue Registry

Columns: **Planted** (beat + method), **Surface read** (what the player/world is meant to think), **True meaning**, **Payoff** (where its real meaning lands).

| ID | Clue | Planted | Surface read | True meaning | Payoff |
|----|------|---------|--------------|--------------|--------|
| C-01 | Mara's "three more sick kids from the Flats this month" | A0-S01, offhand dialogue | Domestic color; overworked-nurse texture | The Lowmarsh cancer/illness cluster is real, visible from a triage desk, and dates back years — the human cost the whole conspiracy is priced against | A3-S15 (Mara's cluster map); A4-S07/S09 (corroborating lattice strand) |
| C-02 | "WHEN THE RAIN RUNS PURPLE" graffiti; purple-rain folktale | A0-S02, environment + optional NPC tale | Local-color folklore, world-building | Literal truth: the Vats leak in storms; the folklore is a suppressed observational record kept by the discarded | A2-S03 (violet leachate seen live, R0); A4-S07 (the sky testifies) |
| C-03 | CLEARWATER re-validation memo | A0-S03, readable inbox document | Office-clutter realism | The frame's *timing motive*: independent federal re-validation will pull TS-19/44 from registries the Vestry can't scrub — the reason Adam must be discredited *now* | A2-S08 (R1 assembly); A4-S01 (the ceremony's sampling clause becomes the plan's doorway) |
| C-04 | Archived TS-19/44 Fig. 12 mismatch + Adam's QA email | A0-S04, interactive discrepancy-spot | Scanning error; mundane diligence | The archive was doctored in 2019; the QA email is the tripwire that accelerates the pre-built frame | A1 (the raid's timing); A2-S08 (forgery confirmed) |
| C-05 | Cordell gave Adam his first notebook; gifts #42; knows the habit intimately | A0-S05, scene business | Warm mentor characterization | The frame's author knew about the notebooks — see C-10; identifies the intimate-knowledge circle (population: one) | A3-S12 (R3 corpus); A4-S02 (R4) |
| C-06 | "The Cordell shortcut" (aquifer-boundary math) established as mentor-lore | A0-S05, dialogue | Charming shop-talk | The doctored Fig. 12 uses this exact shortcut — the forger was MWA-trained; ultimately, taught-by/being Cordell | A2-S08 (noted: "MWA-trained forger"); A3-S12 (attribution flips to Cordell) |
| C-07 | Adam's spare MWA badge missing from the desk drawer | A0-S06, optional environmental detail | Nothing (if noticed at all: misplaced) | Theo lent the badge out for money; cloned, it generated the falsified Records access logs — the frame's physical-access vector | A1-S05 (badge log destroys the marriage); A2-S13 (Theo's confession); A4-S09 (badge-clone forensics + Theo's tape from Marr's archive) |
| C-08 | Stranger photographs Adam & Mara at the anniversary dinner | A0-S07, background event | Creepy city texture | Aegis pre-operation surveillance; the frame is already live three days before the raid | A1 (retrospective); A3-S02 (Whitlock's Fidelis→Aegis thread makes pre-op surveillance legible) |
| C-09 | QA email bounces: "recipient not found" | A0-S08, on-screen UI beat | Server glitch on a bad morning | Records QA intake was already intercepted/rerouted by the certification office — Cordell's office read the tripwire directly | A3-S12/A4-S02 stitch (part of the R3/R4 flashback assembly) |
| C-10 | Search warrant specifies "personal field notebooks (approx. 41 vols.)" | A0-S08, glimpsed document (re-readable in A1 case file) | Thorough cops | Impossible specificity: only someone who knew the private habit — and the *count* — could have sworn that line. Population: one | A3-S12 (R3); flagged by attentive players from Act I |
| C-11 | Count 31: "falsification of hydrological field data, 2018–2020"; plea allocution demands those exact dates | A1-S01 charge sheet; A1-S02 plea scene | Prosecutorial thoroughness | The frame's true target is the *past*: the window brackets TS-19/44 precisely — and matches Cordell's supervision window precisely | A2-S08 (R1); A3-S12 (window attribution) |
| C-12 | Bail posted by "Fidelis Surety," unknown to Adam's own lawyer | A1-S03 | Mysterious benefactor; maybe a friend | Aegis cutout: the Vestry *wants* him out once the plea stalls — flight is public confession, and a loose fugitive can be authored and used | A3-S02 (Whitlock traces shell → Aegis); §4.4 STORY (design logic) |
| C-13 | Defense lawyer: "I've never seen a case build itself like this" | A1-S02, dialogue | Overworked-lawyer despair | Literal description: the case *was* built, then fed to the DA — anticipating defenses implies authorship | A4-S09 (Hale's flip confirms the case was "fed") |
| C-14 | ROOK9 chess account: idiom, care, specificity; annotation-channel tips | A1-S07 onward, recurring | Guardian angel; probably a sympathetic insider | The corpus is the fingerprint: engineering idiom, "castle early" habit, allocution-window knowledge, warrant knowledge. Rook is Cordell, steering | A3-S12 (canary trap + corpus analysis, R3) |
| C-15 | Kray: "Rat swims close to the boat, engineer" | A2-S04, dialogue | Cryptic underworld color; maybe about Duval or Kray herself | Nine. The Ferrywoman clocks informants professionally; her neutrality means she warns once and only once | A3-S11 (Nine unmasked) |
| C-16 | Duval's wall: Coby Anders' drowning; "They don't kill stories, they kill authors" | A2-S05 | A broken crank's collage | The playbook's first run, correctly diagnosed: Adam's frame is edition two; the phrase is the game's method statement | A2-S08 (R1 support); A3-S07 (the playbook runs a third time, on Duval again); A4-S09 |
| C-17 | Archive heist oddities: skeleton crew on purge week; Bay 9 box pre-staged at the dock; evidence seal already broken; alarm trips on *exit* only | A2-S07, level design (each individually explicable) | Luck; good planning; sloppy archive | Choreography: the heist was staged *for* Adam — to taint the original's custody with fugitive fingerprints and to trigger the records-compromise order | A2-S09 (partial: the order lands); A4-S02 (full: the pre-drafted choreography memo in the Vestry annexes) |
| C-18 | Reviewer initials "H.G." (Harold Grady) on the doctored TS-19/44 revision — dated 14 months after Grady's death | A2-S08, evidence-board interaction | Momentarily: "Grady forged it!" (RH-06) | The doctored archive copy is provably a post-hoc forgery: a state document signed by a dead man. Clean, checkable, devastating — the one thread a cop can pull without believing Adam | A2-S14 (mailed to Whitlock); A3-S02 (verified); A4-S09 (vacates the record-poisoning) |
| C-19 | The Nightingale pump hall: maintained machinery, fresh bootprints, maintenance log naming Larkspur Facility Services | A2-S10 (name, via chapel cipher) + A2-S11 (the hall itself) | — (this is discovery, not misdirection) | The cover-up is a *live operating utility*; Larkspur is its payroll skin | A3-S03 (C-34 budget line match); A4-S06 (the machine is the finale's set and lever) |
| C-20 | Nine's fortunes tick upward after each Aegis near-miss; he asks where Adam sleeps; he is never raided | A2-S09 (fortunes uptick, journaled) → A2-S12 (never raided in the bounty era) → A3-S03 (the sleeping question), cumulative texture | Nine's just a good operator | Informant income; target development questions; protected status | A3-S11 (confrontation uses these beats as the proof montage) |
| C-21 | Interception pattern: Aegis is fast only on Nine-brokered jobs | A2-S09, A2-S12, A3-S03 (pattern data the player can correlate) | "They're everywhere" (fugitive paranoia) | They are *somewhere*: the leak has a shape, and the shape is Nine's client list | A3-S10 (Krebs's geotagged notes make it undeniable); A3-S11 |
| C-22 | Escrow schedule: Trust subsidiaries quietly acquired three remediation contractors | A3-S03, stolen document | Diversification boredom (deliberately dry) | The endgame is the *cleanup*: they intend to be paid to remediate their own crime — R2's cornerstone | A3-S04 (R2); A4-S09 (contractors seized; Lena's fund inherits) |
| C-23 | Voss: "Ask the window what the rain paid for" + watch-fob key | A3-S05 | A dying man's riddle | Vestry idiom pointing to the St. Brigid window-as-receipt (C-24) and the family archive (Lena's letters) | A3-S06 (window decoded); A3-S14 (key opens the strongbox); A4-S02 (fob's twin lock in the crypt) |
| C-24 | St. Brigid window: 1975 "restoration" donor panel is a payment cipher; iconography = St. Brigid holding back a violet flood | Visible from A0-S07 (C-33); decodable A3-S06 | Church art; Lowmarsh kitsch | A receipt in glass for the Quiet Covenant — continuity of Vestry knowledge, 1974→, hidden in the one building Lowmarsh would never demolish | A3-S06; A4-S07/S09 (lattice strand) |
| C-25 | The "too good" smoking-gun memo in Adam's stash — the only document Adam never sourced firsthand | Seeded off-screen A2 (by Nine, on Marr's orders); present on the evidence board from late A2 | Best document we have! | A poison pill: pre-planted forgery designed to detonate inside any premature publication and taint everything adjacent | A3-S07 (detonates in Duval's story); A3-S11 (Nine admits placing it); fair-play flag: provenance-less from the moment it appears |
| C-26 | Theo faints at needles (flu-shot joke) | A0-S06, throwaway humor | Character color | The staged-overdose tell: Theo would never inject; his death is murder legible only to family | A3-S08 (Adam reads the scene instantly); A4-S09 (corroborated by Marr-archive cleanup records) |
| C-27 | One backdated "2023" wire in the offshore ledger uses an interbank message format that didn't exist until 2024 | Ledger public from A1-S04; the anachronism is findable by the player in the case-file reader from Act II; formally found A4-S01 (Duval's authentication pass) | The ledger is overwhelming proof of guilt | The frame's single technical flaw: the money history is backdated fiction, provably — and whoever fed the DA the ledger fed him a forgery | A4-S09 (flips Hale; vacates the financial counts) |
| C-28 | Adam's 2019 promotion out of the integrity program, weeks after filing TS-19/44 | Backstory, referenced A0-S03 smalltalk and A2-S08 board | Career milestone | The quiet bribe/removal: bury the finding, elevate the finder away from it. Adam never recognized it; the player can | A2-S08 (R1 support; pinned with its true reading available: "bury the finding, elevate the finder") |
| C-29 | Rook's anomalous "abort the gala" warning | A3-S03 | Rook protecting Adam (consistent with A1-S07) | Ambiguous by design: protecting Adam — or Kessler's floor? The first Rook tip whose beneficiary is unclear; primes the audit instinct | A3-S12 (post-reveal, re-reads as Cordell protecting the *deal*, and perhaps, conflictedly, the student) |
| C-30 | The word "nightingale" in a 1974 Voss family letter | A3-S07 (printed in Duval's burned story) → A3-S14 (Lena's match) | Burned story detritus | Independent-provenance bridge: family papers corroborate the Covenant vocabulary; the failed story functions as a beacon for the last ally | A3-S14 (Lena joins); A4-S09 (letters in the lattice) |
| C-31 | Vestry contingency dossier: "SUCCESSION/CONTAINMENT — MARR, S." | A4-S03 (Nine's extraction) | — | The system always needs an author: the fixer is pre-framed as the next fall guy; the playbook eats its operators (R5) | A4-S06 (Marr stands down); A4-S09 (his archive arrives by courier) |
| C-32 | Konstantin Voss's illness is bladder cancer — the dye-worker's disease; same disease killed Gabriel Vale | Voss's frailty in the A1-S04 news drip (health-desk item); disease named A3-S05; Gabriel's death planted A0-S01 (the rowhouse shelf photograph, examinable, journaled) | Old man dying; sad backstory | The cluster is real and reaches from the Works into both dynasties — poisoner and poisoned share a pathology; the epidemiology clock (R2) is personal | A3-S05; A3-S15 (cluster map); A4-S09 |
| C-33 | The violet window at St. Brigid's — behind Adam & Mara's wedding, visible at the anniversary | A0-S07, environment | Pretty church glass | See C-24; also the theme in one image: the truth stood witness over the protagonist's whole life, unread | A3-S06 (the sacristy wedding-photo gut-punch) |
| C-34 | Budget line: "fountain & waterscape maintenance — $3.1M/yr — Larkspur Facility Services" | A3-S03, stolen escrow schedule | Rich-people landscaping | Nightingale's operating budget wearing a landscaping skin; links Trust money → Larkspur → the pump hall (C-19) | A3-S04 (R2 support); A4-S06 (confirms Aegis/Larkspur crew rotas for the finale plan) |
| C-35 | The fabricated mistress is named "Violet Marsh" | A1-S04 (news drip), A1-S05 (the phone) | Sordid affair detail | The frame's signature vanity: *violet* + *marsh* — the two things being buried, encoded as a taunt by an author with "a poet's contempt" (Duval). Stylistic fingerprint of a mind that hides truths in plain sight — the same mind that keeps minutes in hymn numbers | A3-S12 (corpus/psychology support for R3); NG+ delight |

## 2. Red Herring Registry

Design rule: every red herring is (a) genuinely suggestive on first encounter, (b) fair — the debunking fact exists in-world before or at the plant, (c) explicitly debunked on screen.

| ID | Red herring | Invited misread | Planted | Debunked | Debunk mechanism |
|----|-------------|-----------------|---------|----------|------------------|
| RH-01 | Duval is the leak | Her recklessness + her history of burned sources; the A2-S09 near-miss follows her joining | A2-S09 suspicion montage | A3-S11 | The interception pattern (C-21) never touches Duval-only information; Nine confesses |
| RH-02 | The conspiracy is about the Pier District mega-casino/port scheme | Early stolen documents reference Pier redevelopment; classic "wrong building" misdirection | A1–A2 (documents in the A2-S02/S06 hauls) | A2-S10 | Water permits and drainage maps don't touch the Pier; every hydrological thread drains toward the Vats |
| RH-03 | Mara betrayed Adam / cooperated with the prosecution | Protective order timing; her "cooperation" paperwork; her silence | A1-S05 | A3-S09 (pin signal) → A3-S15 (full) | Her "cooperation" was drafted *for* her under clinic-funding duress; she independently cracks the forged signature (backwards E) and the Violet Marsh phone's impossible purchase date |
| RH-04 | The Verger is Vestry — a plant inside the Undercroft | He bears the Vestry's mark; knows too much; filtered Adam's entry with a riddle | A2-S01 | A2-S10 | The mark is a brand — *given* in exile, not worn in membership; his 1989–90 story is corroborated by the Concordance's custody and by Bell's parish record |
| RH-05 | Konstantin Voss is the mastermind | Old money, old sin, the institute, the name on everything | A2-S10 (the Verger's history names the Voss line as the Vestry's founding blood) → A3-S01 (war-room working theory) → A3-S05 build | A3-S05 (met: a frightened penitent) → A3-S14/A4 (machine accelerates after his death) | Decapitation test: he dies and nothing slows — the engine was Kessler (money) + Cordell (method); Voss was the past trying to die quietly |
| RH-06 | Harold Grady forged the archive copy | His initials sit on the doctored revision | A2-S08 (momentary) | A2-S08 (same scene) | Grady died 14 months before the revision date — the "suspect" is the *proof* (becomes C-18) |
| RH-07 | DA Hale is Vestry inner circle | He fronts the case, blocks Whitlock, feeds the press | A1-S01 → A3-S02 | A4-S09 | He was a consumer of the frame, not an author: C-27 proves the case was fed to him; his instant self-preserving flip is the behavior of a dupe, not a principal |
| RH-08 | Broker Emil Skerry is a conspiracy principal / his testimony is the case's foundation | He's the only human witness; his murder looks like Adam silencing his accuser | A1-S07; murder A2-S12 | A4-S09 | Skerry was rented and disposable; his own "insurance" tapes of his coaching sessions (preserved in Marr's archive) prove the testimony was scripted |

## 3. The Frame-Up: component audit

Every planted-evidence component, its fabrication method, and its dismantling. (Construction schedule: TIMELINE.md §3.)

| Component | Fabricated how | Convinces whom | Dismantled by |
|-----------|----------------|----------------|---------------|
| Offshore ledger (payments from "short-sellers"/fake consultancy) | Skerry-assembled backdated instruments, 2025 | Prosecutors, press, public | C-27 wire-format anachronism (A4-S01→S09) |
| Records badge logs | Theo's borrowed spare badge, cloned (C-07) | Prosecutors; *Mara* (A1-S05) | Theo's confession tape + clone forensics (A2-S13; A4-S09) |
| "Violet Marsh" mistress persona | Two-year fabricated digital identity + planted second phone (C-35) | Mara; the jury pool | Phone provisioning predates its "purchase"; signature traced from mortgage with backwards-E error (A3-S15) |
| Doctored archive TS-19/44 | 2019 revision by Cordell's hand (C-06 shortcut), reviewer initials faked (C-18) | The registries; future validators | Dead-man's-initials anachronism (A2-S08→A3-S02→A4-S09) |
| Skerry's witness testimony | Rented, coached | Grand jury, media | Skerry's own insurance tapes via Marr's archive (A4-S09) |
| Count 31 / allocution text | Drafted to Cordell's specification | The legal record, permanently — *if signed* | Never signed: Adam refuses (A1-S02). The frame's kill-shot fails at the start, and everything else is the conspiracy managing that failure |
| "Disinformation network" narrative | Retroactive absorption of the 2020 Duval leak; authored crimes (warehouse fire, Skerry murder) | Public opinion; the Undercroft's bounty market | The purple rain (A4-S07): a public, physical, unforgeable demonstration outruns narrative for the first time |

**Why the frame is airtight (by design):** it never relies on a single fabrication; each component corroborates the others (money explains motive, badge logs supply opportunity, the mistress supplies character, the witness supplies narrative, the doctored archive supplies the "real" crime). Its authors control the venues of challenge (DA, registries, press cycle).
**Why it still falls:** the one component that required Adam's *cooperation* — the allocution — never lands; and every corroborating strand contains exactly one economical flaw (an anachronism, a phone date, a backwards E, a dead man's initials) because forging the past at scale means racing entropy, and entropy always leaves a receipt. Each flaw is small enough that no single one exonerates; the story's investigation arc is the assembly of all of them into a lattice (A4-S09).

## 4. Antagonist-Advantage Mechanics ("how they stay ahead")

| # | Mechanism | Player-visible symptom | Fair-play clues | Inversion beat |
|---|-----------|------------------------|-----------------|----------------|
| 1 | Nine (human informant, coerced via sister) | Aegis fast on brokered jobs; near-misses | C-15, C-20, C-21 | A3-S11 (flipped to triple agent; false-safehouse feed) |
| 2 | ROOK9 steering (Cordell) | "Perfect" tips; rescues that reshape the board | C-05, C-06, C-09, C-10, C-11, C-14, C-29, C-35 | A3-S12 (canary trap); A3-S13 (mutual knowledge) |
| 3 | Choreographed victories | Wins that come *too* clean | C-17; A2-S09's instant compromise order | A4-S02 (choreography memo); countered by Undercroft-sourced assets the Vestry can't see |
| 4 | Narrative authorship (owned venues: DA, registries, press) | New crimes attributed at will; every leak absorbed | C-13; A3-S07's 48-hour forgery debunk; playbook precedent C-16 | A4-S07 (physical demonstration outside all owned venues) |

Structural counter-mechanic (established from A1-S09, stated at A2-S14, thematized in STORY §6.2): **the Undercroft is illegible to the Vestry.** Every asset acquired below (Verger, Concordance, Kray's tunnels, Nightingale's location, Lena's contact via Duval's ruin) is off their model. The player should be able to sort, in retrospect, every Act II–III gain into "surface-sourced (compromised)" vs. "below-sourced (clean)" — the finale is built exclusively from the second column.

## 5. Reveal Dependency Graph

```
C-02, C-01 ──────────────┐
C-19 (hall) ─────────────┼──▶ R0  The leak is real and maintained (A2-S03→S11)
                         │
C-03, C-04, C-11, C-18, C-28 ──▶ R1  The frame targets the past (A2-S08)
                         │        ▲ requires R0 context (the data must matter)
C-22, C-34, (R0) ────────┼──▶ R2  Liability inversion — farming discovery (A3-S04)
                         │
C-05, C-06, C-09, C-10,  │
C-11, C-14, C-29, C-35 ──┼──▶ R3  Rook = Cordell; choreography (A3-S12; stitch A4-S02)
                         │        ▲ unlocked by eliminating Nine (C-15, C-20, C-21 → A3-S11)
(R3) + Concordance +     │
C-23 key + C-17 memo ────┼──▶ R4  The First Lie, 1988 — why Adam, complete (A4-S02)
                         │
C-31 ────────────────────┴──▶ R5  The next fall guy: Marr (A4-S03→S06)
```

Sequencing constraints (for quest design):
- R1 must land before R2 (the player must know the *past* is the battlefield before understanding who profits from its curation).
- Nine's unmasking (A3-S11) must precede the canary trap (A3-S12): the trap's logic requires all other channels closed.
- R4 must land in Act IV, not III: Adam must go to the cabin (A3-S13) knowing *who* but not yet *why-him* — the scene plays on incomplete knowledge, and R4 then re-grades it.
- C-25 (poison memo) must be on the evidence board at least two missions before A3-S07 so its detonation feels like the player's own oversight.

## 6. Fair-Play Audit (could a careful reader solve it?)

**The central question — "why was Adam specifically framed?" — is solvable from Act I** with: C-03 (re-validation incoming) + C-04 (his old study's archive was doctored) + C-11 (the charges bracket exactly that study's dates). A reader who connects these three concludes: *the frame exists to discredit TS-19/44 before re-validation surfaces it.* That is R1, and it is on the table before the end of the first act. The game buries it under the louder question ("who is hunting me?") — misdirection by urgency, not by concealment.

**The architect — "who could have built this frame?" — is solvable from Act I–II** by intersection: the warrant knew the notebooks (C-10: intimate circle), the allocution knows the supervision window (C-11: MWA senior), the forged math is school-of-Cordell (C-06), the QA intercept sits in the certification office (C-09), Rook's idiom is an engineer's and his chess is Cordell's (C-14 + A0-S05's "castle early"), and the persona-naming shows a cipher-keeper's vanity (C-35). Exactly one person sits in every set. The player's resistance is emotional, not evidentiary — which is the design: **the mystery's armor is the player's affection**, same as Adam's.

**The real objective — "what are they after?" — is solvable at A3-S03** (C-22 + C-34 + the indemnity annex): remediation ownership + liability inversion + a discovery clock = farming, not hiding.

**The mole is solvable at A2-S09** by correlation (C-21) reinforced by C-15 and C-20; the game provides the correlation data honestly (mission-giver metadata in the journal).

**What is deliberately *not* solvable early:** R4's 1988 specifics (the Concordance annex is new information — but its *shape* is guessable from C-06/C-28: whoever buried the 2019 report had a prior stake in the clean record) and the Voss-death ambiguity (permanently unresolved; flagged as authorial intent, not a hole).

## 7. Known pressure points (audited, closed)

| Objection | Answer (in-fiction, on-screen) |
|-----------|--------------------------------|
| "Why not just kill Adam?" | A dead engineer's certifications *stand* and trigger successor review; a convicted/confessed one voids his archive. The plea is the weapon; the fugitive is Plan B; the kill decision arrives (over Cordell's objection) only when Adam becomes more dangerous alive — A2-S12 onward. (STORY §4.4) |
| "Why not destroy all copies of TS-19/44?" | Three registries outside reach (state environmental, court escrow, insurer archive); destruction attempts create fresher, worse records. Discrediting the author poisons all copies at once. (STORY §4.3) |
| "Why did the heist trigger the compromise order if the order helps them — wouldn't they just issue it anyway?" | The order requires a qualifying event (statute); a fugitive defendant burglarizing his own case archive is unimpeachable cause. They manufactured the cause *using* Adam — cheaper and cleaner than any alternative they could stage. (A4-S02 memo) |
| "Why does the independent federal validator not catch the reconstruction?" | It samples archives against registries; post-order, the 'reconstructed' certified archive *is* the record, and contradictory holdings are pre-tagged as products of a convicted falsifier. The validator's independence is real; its inputs are curated. (STORY §4.3) |
| "Why would Cordell help Adam evade re-arrest (A1-S07)?" | Plea failed → fugitive is Plan B (flight = confession) and the choreography needs him operational; plus the one motive Cordell never audits in himself: he'd rather his student run than rot. Sentiment and strategy point the same way, so he never has to choose — until A3-S13. |
| "Why does Kessler let Adam walk at the gala?" | Stated on-screen: arrest at her gala is a headline; a doomed fugitive is a Tuesday. Also true (unstated): Aegis was already inbound; her risk was minutes long. |
| "Why hold the vote during a hundred-year storm?" | The date is statutory (ballot certification) and the ceremony is contractual (grant compliance theater); Vesper's upgrade came inside the immovable window. The Vestry schedules everything except weather — thesis, not hole. (A4-S05) |
| "Why does Marr keep an insurance archive?" | Established character logic: a professional who cleans up after principals *always* keeps receipts (he ran the same play on Duval's editors). C-31 vindicates the habit: his employers were already drafting his frame. |

---

*End of MYSTERY_LOGIC.md v1.0. Any Phase 2+ quest, level, or dialogue that plants, moves, or pays off a clue must update this registry and keep the four design rules in §0 true.*
