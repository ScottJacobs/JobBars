# JobBars
A plugin for [XIVQuickLauncher](https://github.com/goatcorp/FFXIVQuickLauncher) which provides extra job gauges and a party buff tracker

- Number of GCDs under buffs (Fight or Flight, Inner Release)
- DoT tracker (Dia, Miasma)
- Proc display (Verfire/Verstone Ready)
- Number of charges (Ricochet, Gauss Round)
- Number of stacks (Ruin IV)
- Party buffs coming off of cooldown
- Mitigation tracker
- Cursor displays (cast time, GCD timer, MP tick)

https://user-images.githubusercontent.com/18051158/130377508-ee88e07f-b41f-4a39-83db-4b9cc79a47b0.mp4

https://user-images.githubusercontent.com/18051158/130377516-5c299fb5-9a3a-4b47-bb5f-b03297c3ea6f.mp4

https://user-images.githubusercontent.com/18051158/130377606-2490ab26-1c2b-43fa-93f3-80e6c95e9fff.mp4

https://user-images.githubusercontent.com/18051158/130377610-86fb7e17-9780-4827-81df-0739908bd709.mp4

https://user-images.githubusercontent.com/18051158/130377598-2398d33a-9c0c-4d0c-8fd7-4187451a7e56.mp4

## Usage
To open the settings menu, use `/jobbars`

## Why?
Some people find these useful. If you don't, each gauge and buff can enabled or disabled.

## Jobs

**Feel like something is missing? Open an [issue](https://github.com/0ceal0t/JobBars/issues)**

### <img src="assets/job_icons/DRK.png" height="20px" width="20px"> DRK
+ **Gauges**: GCDS used in Delirium, GCDS used in Blood Weapon
+ **Buffs**: Delirium, Living Shadow

### <img src="assets/job_icons/WAR.png" height="20px" width="20px"> WAR
+ **Gauges**: GCDS used in Inner Release, Storm's Eye
+ **Buffs**: Inner Release

### <img src="assets/job_icons/PLD.png" height="20px" width="20px"> PLD
+ **Gauges**: GCDS used in Requiescat, GCDS used in Fight or Flight, Goring Blade

### <img src="assets/job_icons/GNB.png" height="20px" width="20px"> GNB
+ **Gauges**: GCDS used in No Mercy

### <img src="assets/job_icons/SCH.png" height="20px" width="20px"> SCH
+ **Gauges**: Excog, Biolysis
+ **Buffs**: Chain Stratagem

### <img src="assets/job_icons/WHM.png" height="20px" width="20px"> WHM
+ **Gauges**: Dia

### <img src="assets/job_icons/AST.png" height="20px" width="20px"> AST
+ **Gauges**: Combust, Upgraded Earthly Star, Lightspeed
+ **Buffs**: Cards, Divination

### <img src="assets/job_icons/MNK.png" height="20px" width="20px"> MNK
+ **Gauges**: Twin Snakes, Demolish, Charges + time left on Riddle of Earth / True North
+ **Buffs**: Brotherhood, Riddle of Fire

### <img src="assets/job_icons/DRG.png" height="20px" width="20px"> DRG
+ **Gauges**: GCDS used in Lance Charge, GCDS used in Dragonsight, Charges + time left on True North
+ **Buffs**: Battle Litany, Dragonsight, Lance Charge

### <img src="assets/job_icons/NIN.png" height="20px" width="20px"> NIN
+ **Gauges**: GCDS used in Bunshin, Charges + time left on True North
+ **Buffs**: Trick Attack, Bunshin

### <img src="assets/job_icons/SAM.png" height="20px" width="20px"> SAM
+ **Gauges**: Jinpu, Shifu, Higanbana, Charges + time left on True North
+ **Buffs**: Double Midare

### <img src="assets/job_icons/BRD.png" height="20px" width="20px"> BRD
+ **Gauges**: GCDS used in Raging Strikes, Caustic Bite, Stormbite
+ **Buffs**: Battle Voice, Raging Strikes, Barrage

### <img src="assets/job_icons/MCH.png" height="20px" width="20px"> MCH
+ **Gauges**: GCDS used in Hypercharge, GCDS used in Wildfire, Charges of Ricochet, Charges of Gauss Round
+ **Buffs**: Wildfire, Reassemble

### <img src="assets/job_icons/DNC.png" height="20px" width="20px"> DNC
+ **Gauges**: Procs
+ **Buffs**: Technical Step, Devilment

### <img src="assets/job_icons/BLM.png" height="20px" width="20px"> BLM
+ **Gauges**: Thunder 3+4, Fire and Thunder procs

### <img src="assets/job_icons/SMN.png" height="20px" width="20px"> SMN
+ **Gauges**: Ruin 4, Bio, Miasma, Wyrmwave and Scarlet Flame
+ **Buffs**: Devotion, Summon Bahamut, Firebird Trance

### <img src="assets/job_icons/RDM.png" height="20px" width="20px"> RDM
+ **Gauges**: GCDS used in Manification, Fire and Stone procs, Acceleration stacks
+ **Buffs**: Embolden, Manafication

### <img src="assets/job_icons/BLU.png" height="20px" width="20px"> BLU
+ **Gauges**: Song of Torment, Bad Breath, Condensed Libra
+ **Buffs**: Off-guard, Peculiar Light

## TODO
- [ ] Completely custom gauges/buffs/cds (requires big rework)
- [ ] Support crossbar for icon replacement
- [ ] Hide based on level
- [ ] How many people got hit by buffs
- [ ] Glow around gauges
- [ ] Replicate or attach to existing gauges
- [ ] Split up party buffs and personal buffs
- [ ] SMN DoTs at 6 seconds [see this issue](https://github.com/0ceal0t/JobBars/issues/9)
- [x] ~~GCD timer~~ (cursor)
- [x] ~~DoT tick timer / MP timer~~ (cursor)
- [x] ~~Add invert counter option to GCDs~~
- [x] ~~Better bar placement options~~
- [x] ~~Animate gauge movement~~ (kinda)
- [x] ~~Hide all gauges options~~
- [x] ~~Hide all buffs options~~
- [x] ~~MCH number of charges of Gauss Round / Richochet~~
- [x] ~~Track DoTs based on target~~
- [x] ~~AST upgraded star~~
- [x] ~~Move gauges independently~~
- [x] ~~Sound effect when DoTs are low~~
- [x] ~~Red text when DoTs are low~~
- [x] ~~Remove buffs on instance end~~
- [x] ~~Remove buffs on party change~~
- [x] ~~Dia messes up battle stance icon~~
- [x] ~~Border around buffs~~
