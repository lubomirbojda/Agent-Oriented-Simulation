# Hospital Emergency Department (Agent-Oriented Simulation — ABASim)

[![C#](https://img.shields.io/badge/Language-C%23%2012-239120.svg)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![.NET 8](https://img.shields.io/badge/Framework-.NET%208.0-512BD4.svg)](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
[![ABASim](https://img.shields.io/badge/Core-ABASim%20%2F%20OSPABA-00599C.svg)](https://fri.uniza.sk)
[![UI](https://img.shields.io/badge/UI-WinForms%20%2B%20WPF%20Animator-0078D6.svg)](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/)
[![Plotting](https://img.shields.io/badge/Plotting-ScottPlot%205.1-6B46C1.svg)](https://scottplot.net/)
[![IDE](https://img.shields.io/badge/IDE-Visual%20Studio-purple.svg)](https://visualstudio.microsoft.com/)
[![Course](https://img.shields.io/badge/Course-Discrete%20Simulation-orange.svg)](https://fri.uniza.sk)

High-performance C# / Windows Forms desktop application and **agent-oriented discrete-event simulation (ABASim / OSPABA)** of a regional hospital's **24/7 Emergency Department (Urgentný príjem)**, featuring **6 cooperating agents**, **live 2D WPF animation (`OSPAnimator`)**, **custom random variate generators** (Erlang, Exponential, Triangular, Uniform, and Empirical), **online sample and time-weighted statistical collectors**, and **multi-strategy resource allocation optimization**.

This project was developed as a university semester project (**Semester Project S3**) for the **Discrete Simulation (Diskrétna simulácia)** course at the Faculty of Management Science and Informatics, University of Žilina (**FRI UNIZA**).

---

## Table of Contents

- [Overview](#overview)
- [Key Features](#key-features)
- [Agent-Oriented Architecture & Random Generators](#agent-oriented-architecture--random-generators)
- [Hospital Emergency Department Model](#hospital-emergency-department-model)
- [Input Data Analysis, Warm-Up & Experimental Results](#input-data-analysis-warm-up--experimental-results)
- [Installation & How to Run](#installation--how-to-run)
- [GUI Controls & Usage](#gui-controls--usage)
- [Documentation](#documentation)
- [Screenshots](#screenshots)

---

## Overview

The management of a regional hospital's emergency department faces growing patient volumes and prolonged waiting times under constrained staffing capacities. The goal of this simulation study is to model the continuous **24/7 operation of the emergency department** over a **28-day replication horizon** (preceded by a **72-hour warm-up phase**), evaluate different resource allocation rules, and determine the **minimum required number of nurses and doctors** so that:
- **Ambulance patients** wait on average **`≤ 15 minutes`** (`00:15:00`) from entering the hospital building to the start of their medical examination,
- **Walk-in patients** (arriving on foot) wait on average **`< 30 minutes`** (`00:30:00`) from entering the hospital building to the start of their medical examination.

Two distinct patient streams arrive at the emergency department: **walk-in patients** (`Prišiel sám`) and **ambulance patients** (`Privezený sanitkou`), differing in arrival distributions, walking/transfer times, triage priority probabilities, and examination durations:
1. **Entrance Triage Examination (`Vstupné vyšetrenie`):** Upon walking from the building entrance to the waiting room, patients enter a priority entrance queue (`QueueEntrancePatients`) where ambulance patients take precedence over walk-in patients (FIFO within each group). Triage requires the simultaneous availability of **1 Nurse** and **1 Type B Examination Room (`AmbulanceB`)**. Upon completion, the patient is assigned a clinical **priority from `1` (highest) to `5` (lowest)**.
2. **Main Medical Examination (`Lekárske ošetrenie`):** Based on their assigned priority, patients wait in priority queues (`PriorityQueuesAmbulances`, ordered by priority `1..5` and arrival order) for an eligible examination room (**`5` Type A rooms** and **`7` Type B rooms**):
   - **Priority `1` and `2`:** Can only be treated in **Type A** examination rooms (`AmbulanceA`).
   - **Priority `3` and `4`:** Can be treated in **either Type A or Type B** examination rooms (`AmbulanceA` or `AmbulanceB`).
   - **Priority `5`:** Can only be treated in **Type B** examination rooms (`AmbulanceB`).
   - Main medical treatment is non-preemptive and requires the simultaneous availability of **1 Doctor**, **1 Nurse**, and **1 eligible Examination Room (`A` or `B`)**.
3. **Staff Movement & Departure:** Medical personnel (`Doctor`, `Nurse`) remain at the examination room where they finished their last task and must physically walk (`15–45 s`) whenever reassigned to a different room. After medical treatment, the patient walks (`150–240 s`) to the pedestrian exit and leaves the system.

---

## Key Features

- **Agent-Oriented Architecture (`ABASim` / `OSPABA`):**
  - Designed in **ABABuilder** and decomposed into **6 hierarchical agents** (`AgentBoss`, `AgentEnviroment`, `AgentHospital`, `AgentResources`, `AgentEntranceTreat`, `AgentMedicalTreat`), each with a dedicated `Manager` and `ContinualAssistants` (`Scheduler` and `Process` components) communicating exclusively via strongly-typed messages (`MyMessage`, `Mc`).
- **Three Configurable Resource Allocation Strategies (`ResourcesAssign`):**
  - Supports runtime switching and experimental comparison between **`BASIC_FCFS`** (First-Come, First-Served with medical treatment priority), **`SMART_ENTRANCE`** (priority-driven medical treatment with nurse/room reserve throttling), and **`BACKPRESSURE_CONTROL`** (dynamic entrance triage suspension when the doctor queue reaches `≥ 3` patients).
- **Custom Probability Distribution Suite (`Generators`):**
  - Built entirely from scratch using `System.Random` without relying on simulation core generators: **Erlang** (`ErlangDist` as a sum of `k` independent Exponential variates), **Exponential** (`ExponentialDist`), **Triangular** (`TriangularDist`), **Continuous & Discrete Uniform** (`ContinuousUniform`, `DiscreteUniform`), and **Continuous & Discrete Empirical** (`ContinuousEmpiric`, `DiscreteEmpiric`).
- **Two-Stage Statistical Evaluation with 95% Confidence Intervals (`Statistics`):**
  - Custom `SimpleStatistics` (sample mean, standard deviation, `90%` and `95%` confidence intervals) and `TimeStatistics` (exact time-weighted continuous integral `∫ L(t) dt / (T - T_0)` for entrance queue length and staff/room utilizations) tracking **17 performance metrics** within and across replications.
- **Interactive 2D Hospital Animation (`OSPAnimator` via WPF `ElementHost`):**
  - Real-time visual rendering of the emergency department layout (**5 Type A rooms** in light blue, **7 Type B rooms** in yellow, staff staging areas, and room entry nodes) with live animated movement of **Patients** (green circles), **Nurses** (purple circles), and **Doctors** (dark blue circles).
- **Live Convergence Plotting (`ScottPlot.WinForms`):**
  - Real-time stabilization charts tracking the cross-replication mean waiting time for medical treatment (separately for ambulance and walk-in patients) across replications after discarding the initial `20%` transient replication prefix.

---

## Agent-Oriented Architecture & Random Generators

### Agent Hierarchy & Continual Assistants

```text
MySimulation (OSPABA.Simulation)
 └── AgentBoss (Root coordinator — manages overall patient lifecycle)
      ├── AgentEnviroment (External arrival environment & departure sink)
      │    ├── ManagerEnviroment
      │    ├── SchedulerAlonePatientArrival      (Exponential inter-arrival scheduler)
      │    └── SchedulerAmbulancePatientArrival  (Erlang k=7 inter-arrival scheduler)
      │
      └── AgentHospital (Patient flow coordinator & spatial movement controller)
           ├── ManagerHospital
           ├── ProcessMoveToEntranceSpace        (Walk/transfer from entrance to waiting room)
           ├── ProcessMoveToAmbulance            (Concurrent walk of patient, nurse & doctor to room)
           ├── ProcessMoveToLeaveDoor            (Walk from examination room to hospital exit)
           │
           ├── AgentResources (Medical staff & examination room allocator)
           │    ├── ManagerResources             (Executes BASIC_FCFS, SMART_ENTRANCE, or BACKPRESSURE_CONTROL)
           │    ├── Resources<Nurse>             (Configurable count, default: 8)
           │    ├── Resources<Doctor>            (Configurable count, default: 6)
           │    ├── Resources<AmbulanceA>        (Fixed: 5 Type A rooms)
           │    └── Resources<AmbulanceB>        (Fixed: 7 Type B rooms)
           │
           ├── AgentEntranceTreat (Triage & priority assignment unit)
           │    ├── ManagerEntranceTreat
           │    └── ProcessEntranceTreat         (Executes triage & assigns priority 1..5)
           │
           └── AgentMedicalTreat (Main medical examination unit)
                ├── ManagerMedicalTreat
                └── ProcessMedicalTreat          (Executes doctor + nurse examination)
```

### Message Passing Protocol (`Mc`)

| Message Code (`Mc`) | Message Type | Sender → Addressee | Purpose |
| :--- | :---: | :--- | :--- |
| **`PatientArrived`** | `Notice` | `Scheduler*` → `AgentEnviroment` | Internal notification when a walk-in or ambulance patient is generated |
| **`PatientArrival`** | `Notice` | `AgentEnviroment` → `AgentBoss` | Notifies the root agent that a new `Patient` has entered the hospital |
| **`TreatPatient`** | `Request` / `Response` | `AgentBoss` ↔ `AgentHospital` | Initiates the patient's hospital lifecycle and returns upon hospital exit |
| **`TryAssignResources`** | `Notice` | `AgentHospital` → `AgentResources` | Triggers resource allocation check upon arrival to queue or treatment end |
| **`ResourcesAssigned`** | `Notice` | `AgentResources` → `AgentHospital` | Dispatches an assigned patient (with `Nurse`, `Ambulance`, and `Doctor`) to move to the room |
| **`EntranceTreat`** | `Request` / `Response` | `AgentHospital` ↔ `AgentEntranceTreat` | Performs entrance triage in `AmbulanceB` with a `Nurse` and assigns priority `1..5` |
| **`MedicalTreat`** | `Request` / `Response` | `AgentHospital` ↔ `AgentMedicalTreat` | Performs main medical treatment in `AmbulanceA/B` with `Doctor` + `Nurse` |
| **`PatientLeave`** | `Notice` | `AgentBoss` → `AgentEnviroment` | Records final system residence time statistics and increments served counters |

### Custom Random Generators & Statistical Collectors

```text
Generators
 ├── ErlangDist                (Sum of k independent ExponentialDist variates)
 ├── ExponentialDist           (Inverse transform: -ln(1 - r) / λ)
 ├── TriangularDist            (Piecewise inverse CDF on [min, max] with mode c)
 ├── BaseUniform<T>
 │    ├── DiscreteUniform      (int: [min, max] inclusive)
 │    └── ContinuousUniform    (double: [min, max) half-open)
 └── BaseEmpiric<T, TInterval>
      ├── DiscreteEmpiric      (Multi-interval discrete empirical distribution)
      └── ContinuousEmpiric    (Piecewise uniform continuous empirical distribution)

Statistics
 ├── SimpleStatistics          (Unweighted sample mean, variance, standard error, 90% & 95% CI)
 └── TimeStatistics            (Time-weighted continuous integral ∫ X(t) dt / (T - T_0) with ResetAtTime)
```

---

## Hospital Emergency Department Model

### 1. Stochastic Process Parameters

All arrival distributions (fitted in Arena Input Analyzer from empirical datasets `alone_patients.txt` and `ambulance_patients.txt`), walking times, triage priority distributions, and treatment durations follow the assignment specification:

| Process / Operation | Patient Group / Entity | Distribution Class | Parameters | Mean Value |
| :--- | :--- | :--- | :--- | :---: |
| **Inter-Arrival Time** | Walk-in (`Prišiel sám`) | `ExponentialDist` | `EXPO(β = 9.57 min)`, `λ = 1 / (9.57 × 60) s⁻¹` | `574.20 s` (`9.57 min`) |
| **Inter-Arrival Time** | Ambulance (`Sanitka`) | `ErlangDist` | `ERLA(β = 0.836 min, k = 7)`, `λ = 1 / (0.836 × 60) s⁻¹` | `351.12 s` (`5.852 min`) |
| **Walk to Triage Queue** | Walk-in (`Prišiel sám`) | `TriangularDist` | `min = 120 s, max = 300 s, mode = 150 s` | `190.00 s` |
| **Transfer to Triage Queue** | Ambulance (`Sanitka`) | `ContinuousUniform` | `U ∈ [90, 200) s` | `145.00 s` |
| **Entrance Triage Duration** | Walk-in (`Prišiel sám`) | `ContinuousEmpiric` | `[3, 5) min (0.60)`, `[5, 9) min (0.40)` | `312.00 s` (`5.20 min`) |
| **Entrance Triage Duration** | Ambulance (`Sanitka`) | `DiscreteUniform` | `T_min = 240 s (4 min)`, `T_max = 480 s (8 min)` | `360.00 s` (`6.00 min`) |
| **Priority Assignment (`1..5`)** | Walk-in (`Prišiel sám`) | `DiscreteEmpiric` | `P1`: `10%`, `P2`: `20%`, `P3`: `15%`, `P4`: `25%`, `P5`: `30%` | `3.45` |
| **Priority Assignment (`1..5`)** | Ambulance (`Sanitka`) | `DiscreteEmpiric` | `P1`: `30%`, `P2`: `25%`, `P3`: `20%`, `P4`: `15%`, `P5`: `10%` | `2.50` |
| **Transfer Between Rooms** | `Patient`, `Nurse`, `Doctor` | `TriangularDist` | `min = 15 s, max = 45 s, mode = 20 s` (if room changes) | `26.67 s` |
| **Main Medical Treatment** | Walk-in (`Prišiel sám`) | `ContinuousEmpiric` | `[10, 12) min (0.1)`, `[12, 14) min (0.6)`, `[14, 18) min (0.3)` | `822.00 s` (`13.70 min`) |
| **Main Medical Treatment** | Ambulance (`Sanitka`) | `ContinuousUniform` | `U ∈ [15, 30) min` (`[900, 1800) s`) | `1350.00 s` (`22.50 min`) |
| **Walk to Building Exit** | All Patients | `ContinuousUniform` | `U ∈ [150, 240) s` | `195.00 s` |

### 2. Queuing, Room Eligibility & Transfer Rules

1. **Entrance Waiting Room (`QueueEntrancePatients`):**
   - Contains two internal FIFO queues (`QueueEntranceAmbulancePatients` and `QueueEntranceAlonePatients`).
   - Dequeuing strictly prioritizes `QueueEntranceAmbulancePatients` over `QueueEntranceAlonePatients`.
2. **Multi-Room Priority Queues (`PriorityQueuesAmbulances`):**
   - Implemented via two `SortedList<(int priority, int order), Patient>` collections: `QueueAmbulanceA` and `QueueAmbulanceB`.
   - After entrance triage in a **Type B** room, patients with priority `1` or `2` are enqueued into `QueueAmbulanceA`, patients with priority `5` into `QueueAmbulanceB`, and patients with **priority `3` or `4` are enqueued into both `QueueAmbulanceA` and `QueueAmbulanceB`**.
   - As soon as a priority `3` or `4` patient is dequeued from either `QueueAmbulanceA` or `QueueAmbulanceB`, they are automatically removed from the other queue (`DequeuePatient`).
3. **Synchronized Multi-Entity Room Transfer (`ProcessMoveToAmbulance`):**
   - At `t = 0`, all staff start at the ambulance entrance (`LastAmbulance = null`). After completing any task, a `Nurse`, `Doctor`, or `Patient` remains at their current room (`LastAmbulance`).
   - When assigned to a new examination room (`ActualAmbulance != LastAmbulance`), each moving entity independently samples a transfer time from `TriangularDist(15, 45, 20)`. If an entity is already in the target room (e.g., a `Priority 3–5` patient remaining in the same `AmbulanceB` after triage), their transfer time is `0 s`.
   - The examination starts only after all required participants arrive: `Δt_move = max(t_doctor, t_nurse, t_patient)`.

---

## Input Data Analysis, Warm-Up & Experimental Results

### 1. Input Arrival Stream Analysis (Arena Input Analyzer)

Empirical inter-arrival times (in minutes) extracted from `patientsarrival.xlsx` (`alone_patients.txt` with `N = 903` observations and `ambulance_patients.txt` with `N = 1,476` observations) were fitted and validated using **Chi-Square (`χ²`)** and **Kolmogorov–Smirnov (`K–S`)** goodness-of-fit tests in **Arena Input Analyzer**:

| Patient Stream | Sample Size (`N`) | Best-Fit Distribution | Fitted Expression (Minutes) | Sample Mean / Std Dev | `χ²` Test (`p`-value) | `K–S` Test (`p`-value) | Square Error |
| :--- | :---: | :--- | :---: | :---: | :---: | :---: | :---: |
| **Walk-in (`Prišiel sám`)** | `903` | **Exponential** (`ExponentialDist`) | `-0.001 + EXPO(9.57)` | `9.57` / `9.35 min` | `χ² = 9.2` (`df = 16`, `p > 0.75`) | `0.0153` (`p > 0.15`) | `0.000629` |
| **Ambulance (`Sanitka`)** | `1,476` | **Erlang** (`ErlangDist`) | `ERLA(0.836, 7)` | `5.85` / `2.19 min` | `χ² = 22.0` (`df = 25`, `p = 0.63`) | `0.0213` (`p > 0.15`) | `0.000610` |

---

### 2. Steady-State Warm-Up Analysis (`72 Hours`)

Because the hospital starts completely empty at `t = 0`, initial patients experience zero queuing delays. To determine the warm-up period (`WarmUpEndTime`), a long-horizon baseline run of **`200` simulated days** (`4,800 hours`) was executed under `BASIC_FCFS` with `12 Nurses` and `10 Doctors` (`Program.cs` → `warmupanalyze.csv`), logging the cumulative mean time in system every hour.

Visual inspection (eyeballing method) of the trajectory shows strong initial oscillations during the first `50 hours`, stabilizing around `≈ 1,925 s` after **`72 hours` (`3 days`)**. Consequently, every replication runs for **`72 hours` of warm-up** (at which point `ResetStatsAfterWarmUp()` resets all counters, `SimpleStatistics`, and `TimeStatistics` via `ResetAtTime(CurrentTime)`), followed by **`28 days` (`672 hours` / `2,419,200 s`)** of steady-state data collection.

---

### 3. Resource Allocation Strategies & Staffing Optimization (`200 Replications`)

Three resource allocation strategies were designed and evaluated in `ManagerResources` across **`200` replications** (`72 h` warm-up + `28 days` active simulation per replication) to find the minimum number of nurses and doctors satisfying both waiting-time SLA constraints (`Wait_Medical_Ambulance ≤ 15 min` and `Wait_Medical_WalkIn < 30 min`):

1. **`BASIC_FCFS` (First-Come, First-Served — Recommended):**
   - Prioritizes main medical examinations (`QueueAmbulanceA` first, then `QueueAmbulanceB`) whenever a doctor, nurse, and room are free; remaining free nurses and Type B rooms are immediately assigned to entrance triage (`QueueEntrancePatients`).
   - **Minimum Required Staff:** **`8` Nurses** and **`6` Doctors**.
2. **`SMART_ENTRANCE` (Cross-Queue Priority & Nurse/Room Reserve Throttling):**
   - Compares the highest-priority patient across both `QueueAmbulanceA` and `QueueAmbulanceB` (`priorityA <= priorityB`) to dispatch medical treatment in strict clinical priority order. Additionally, when all doctors are busy (`freeDoctorsCount == 0`), new entrance triage examinations are throttled unless at least `2 Nurses` and `2 Type B rooms` remain free.
   - **Minimum Required Staff:** **`9` Nurses** and **`6` Doctors** (requires `+1 Nurse` compared to `BASIC_FCFS` due to reserve throttling).
3. **`BACKPRESSURE_CONTROL` (Cross-Queue Priority & Doctor Queue Backpressure):**
   - Uses cross-queue priority ordering for medical treatment and monitors total congestion in front of the doctors (`waitingForDoctorCount = queueAmbA.Count + queueAmbB.Count`). Whenever `≥ 3` patients are waiting for a doctor, all new entrance triage examinations are suspended (`waitingForDoctorCount >= 3`).
   - **Minimum Required Staff:** **`8` Nurses** and **`6` Doctors** (meets SLA with the same staff count as `BASIC_FCFS`, but increases walk-in medical waiting time by `~4.5 minutes` and overall time in system by `~1.5 minutes`).

#### Detailed Comparison Across Strategies (`200` Replications, `72 h` Warm-Up, `28 Days` Horizon)

| Performance Metric | `1. BASIC_FCFS` (`8 Nurses, 6 Doctors`)<br>Mean \| `95% CI` | `2. SMART_ENTRANCE` (`9 Nurses, 6 Doctors`)<br>Mean \| `95% CI` | `3. BACKPRESSURE_CONTROL` (`8 Nurses, 6 Doctors`)<br>Mean \| `95% CI` |
| :--- | :---: | :---: | :---: |
| **Served Patients — Total** | `11,105.96` \| `[11,096.05 ; 11,115.87]` | `11,098.99` \| `[11,087.82 ; 11,110.15]` | `11,098.11` \| `[11,087.97 ; 11,108.25]` |
| **Served Patients — Walk-in (`Pešo`)** | `4,218.27` \| `[4,209.53 ; 4,227.01]` | `4,209.01` \| `[4,199.08 ; 4,218.93]` | `4,212.53` \| `[4,203.53 ; 4,221.52]` |
| **Served Patients — Ambulance (`Sanitka`)** | `6,887.69` \| `[6,883.18 ; 6,892.20]` | `6,889.98` \| `[6,885.51 ; 6,894.45]` | `6,885.59` \| `[6,881.25 ; 6,889.92]` |
| **Time in System — All Patients** | **`00:36:46`** \| `[00:36:42 - 00:36:50]` | `00:36:37` \| `[00:36:32 - 00:36:42]` | `00:38:17` \| `[00:38:10 - 00:38:24]` |
| **Time in System — Walk-in (`Pešo`)** | **`00:34:26`** \| `[00:34:19 - 00:34:33]` | `00:34:04` \| `[00:33:55 - 00:34:13]` | `00:38:49` \| `[00:38:32 - 00:39:06]` |
| **Time in System — Ambulance (`Sanitka`)** | **`00:38:11`** \| `[00:38:09 - 00:38:13]` | `00:38:10` \| `[00:38:08 - 00:38:13]` | `00:37:58` \| `[00:37:56 - 00:37:59]` |
| **Wait for Triage — All Patients** | `00:04:05` \| `[00:04:04 - 00:04:06]` | `00:03:51` \| `[00:03:49 - 00:03:52]` | `00:07:12` \| `[00:07:05 - 00:07:19]` |
| **Wait for Triage — Walk-in (`Pešo`)** | `00:05:55` \| `[00:05:52 - 00:05:57]` | `00:05:23` \| `[00:05:21 - 00:05:26]` | `00:13:07` \| `[00:12:51 - 00:13:24]` |
| **Wait for Triage — Ambulance (`Sanitka`)** | `00:02:58` \| `[00:02:57 - 00:02:58]` | `00:02:54` \| `[00:02:53 - 00:02:54]` | `00:03:35` \| `[00:03:34 - 00:03:35]` |
| **Mean Triage Queue Length (`Dĺžka radu`)** | **`1.30837`** \| `[1.30350 - 1.31324]` | `1.25251` \| `[1.24718 - 1.25784]` | `2.12524` \| `[2.09458 - 2.15589]` |
| **Wait for Treatment — All Patients** | `00:13:52` \| `[00:13:48 - 00:13:56]` | `00:13:43` \| `[00:13:38 - 00:13:48]` | `00:15:23` \| `[00:15:16 - 00:15:31]` |
| **Wait for Treatment — Walk-in (`< 30 min`)** | **`00:17:00`** \| **`[00:16:53 - 00:17:07]`** | `00:16:38` \| `[00:16:29 - 00:16:47]` | `00:21:23` \| `[00:21:06 - 00:21:40]` |
| **Wait for Treatment — Ambulance (`≤ 15 min`)** | **`00:11:56`** \| **`[00:11:54 - 00:11:59]`** | `00:11:56` \| `[00:11:54 - 00:11:59]` | `00:11:43` \| `[00:11:42 - 00:11:45]` |
| **Utilization — Nurses (`Sestričky`)** | **`87.97%`** (`0.87968`) \| `[0.87900 - 0.88037]` | `78.18%` (`0.78177`) \| `[0.78110 - 0.78243]` | `88.05%` (`0.88048`) \| `[0.87977 - 0.88118]` |
| **Utilization — Doctors (`Doktori`)** | **`90.20%`** (`0.90197`) \| `[0.90125 - 0.90269]` | `90.15%` (`0.90152`) \| `[0.90074 - 0.90230]` | `90.14%` (`0.90135`) \| `[0.90062 - 0.90208]` |
| **Utilization — Examination Rooms A (`5x`)** | **`84.24%`** (`0.84239`) \| `[0.84179 - 0.84299]` | `84.22%` (`0.84222`) \| `[0.84159 - 0.84284]` | `84.50%` (`0.84502`) \| `[0.84435 - 0.84569]` |
| **Utilization — Examination Rooms B (`7x`)** | **`40.36%`** (`0.40364`) \| `[0.40312 - 0.40417]` | `40.36%` (`0.40355`) \| `[0.40297 - 0.40412]` | `40.27%` (`0.40267`) \| `[0.40218 - 0.40317]` |

> **Conclusion:** **`BASIC_FCFS` with `8 Nurses` and `6 Doctors`** is the optimal operational configuration. Reducing either resource (`7 Nurses` or `5 Doctors`) violates the waiting time constraints, whereas `SMART_ENTRANCE` requires `9 Nurses` and `BACKPRESSURE_CONTROL` degrades walk-in waiting times (`00:21:23` vs. `00:17:00`) and increases the entrance triage queue length (`2.13` vs. `1.31` patients).

---

## Installation & How to Run

### Prerequisites

- **Operating System:** Windows 10 / 11
- **SDK:** [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) (`net8.0` / `net8.0-windows`)
- **IDE:** [Visual Studio 2022 / 2026](https://visualstudio.microsoft.com/) (with *.NET desktop development* workload)
- **Bundled Dependencies:** `ABACore.dll` (located in `DS_SEM_3/lib/ABACore.dll`) and `ScottPlot.WinForms 5.1.58` (restored automatically via NuGet)

### Steps

1. **Clone the repository:**
   ```bash
   git clone https://github.com/lubomirbojda/Agent-Oriented-Simulation
   cd Agent-Oriented-Simulation
   ```

2. **Open the solution:**
   - Open `DS_SEM_3.slnx` in Visual Studio.

3. **Choose the Startup Project:**
   - **Hospital Simulation & Animation Monitor (WinForms + WPF GUI):** Right-click `GUI` in Solution Explorer → **Set as Startup Project**.
   - **200-Day Warm-Up Analyzer & CSV Exporter (Console):** Right-click `DS_SEM_3` in Solution Explorer → **Set as Startup Project**.

4. **Build & Run:**
   - Select `Release` or `Debug` configuration and press `F5` or `Ctrl + F5`.
   - Or run directly from the CLI:
     ```bash
     # Launch the main Windows Forms Hospital Simulation & Animation GUI
     dotnet run --project GUI -c Release

     # Run the 200-day console warm-up analysis (exports warmupanalyze.csv)
     dotnet run --project DS_SEM_3 -c Release
     ```

---

## GUI Controls & Usage

### Top Control Panel
- **`Spustiť` / `Ukončiť`:** Starts or stops the multi-replication simulation asynchronously (`SimulateAsync`).
- **`Pozastaviť` / `Pokračovať`:** Pauses and resumes the simulation mid-replication.
- **`Maximálna rýchlosť`:** Enables Turbo mode (`SetMaxSimSpeed()`), disabling UI step delays to execute replications at maximum CPU speed.
- **`Ovládanie rýchlosti` (`Trvanie pauzy` & `Interval`):** Dual sliders (`TrackBar`) adjusting `SetSimSpeed(interval, pause)` for smooth real-time monitoring and animation playback.
- **`Nastavenia simulácie`:**
  - **`Replikácie`** (default `200`): Number of Monte Carlo replications (`28` simulated days each).
  - **`Zahrievanie (h)`** (default `72`): Warm-up duration in simulated hours before resetting within-replication statistics.
  - **`Sestričky`** (default `8`): Number of nurses in `AgentResources`.
  - **`Doktori`** (default `6`): Number of doctors in `AgentResources`.
  - **`Prideľovanie`**: Dropdown selector for the resource allocation strategy (`BASIC_FCFS`, `SMART_ENTRANCE`, `BACKPRESSURE_CONTROL`).
- **`Nastavenie animátora` (`Vytvoriť animátor` / `Vymazať animátor`):** Initializes or removes the embedded WPF `OSPAnimator` canvas when on the `Animácia` tab.

### Main Application Tabs
1. **Tab `Simulácia` (Live Entity & Resource State Tables):**
   - **`Pacienti`:** Live `DataGridView` of all patients currently in the hospital (`Id`, `Prišiel sanitkou?`, `Čakanie na vstupné vyšetrenie`, `Vstupné vyšetrenie hotové`, `Priorita`, `Čakanie na lekárske ošetrenie`, `Aktuálne priradená sestrička`, `Aktuálne priradený doktor`, `Aktuálne priradená ambulancia`).
   - **`Doktori` & `Sestričky`:** Real-time status (`Je zaneprázdnený?`) and current room location (`A_0..A_4`, `B_0..B_6`) of every doctor and nurse.
   - **`Ambulancie A` & `Ambulancie B`:** Live occupancy (`Je obsadená?`) and IDs of the currently assigned `Pacient`, `Sestrička`, and `Doktor` for all `5` Type A and `7` Type B rooms.
2. **Tab `Animácia` (2D Interactive WPF Animator):**
   - Renders the spatial layout of the `5` Type A rooms (top row, light blue) and `7` Type B rooms (bottom row, yellow), nurse/doctor staging areas, and smooth real-time movement trajectories of patients, nurses, and doctors between rooms.
3. **Tab `Štatistiky` (Cross-Replication Means & 95% Confidence Intervals):**
   - Displays all **17 tracked metrics** (served patient counts, times in system formatted as `hh:mm:ss`, waiting times for triage and medical treatment, time-weighted entrance queue length, and resource utilizations) along with their **95% confidence intervals**.
4. **Tab `Grafy` (Replication Stabilization Charts):**
   - Plots two live `ScottPlot` scatter/line charts (**`Čakanie na ošetrenie (sanitka)`** and **`Čakanie na ošetrenie (pešo)`**) showing the convergence of the cumulative mean waiting time across replications (automatically skipping the initial `20%` of replications to zoom in on steady-state convergence).

---

## Documentation

Complete technical documentation (in Slovak) is included in the repository root:

- **[Project Documentation (PDF)](https://github.com/lubomirbojda/Agent-Oriented-Simulation/blob/main/Documentation.pdf)**
  - Agent-oriented architecture designed in **ABABuilder** (`AgentBoss`, `AgentEnviroment`, `AgentHospital`, `AgentResources`, `AgentEntranceTreat`, `AgentMedicalTreat`), message diagrams, and continual assistants
  - Input data analysis and goodness-of-fit tests in **Arena Input Analyzer** (`Exponential` for walk-in patients, `Erlang(k=7)` for ambulance patients)
  - Detailed comparison of the 3 resource allocation rules (`First Come First Served`, `Smart Entrance`, `Backpressure Control`) with full `95%` confidence interval tables
  - Steady-state warm-up analysis (`72 hours` determined from a `200-day` trace)

> **Note:** PDF documentation is written in the **Slovak language**.

---

## Screenshots

<p align="center">
  <img width="1149" height="787" alt="image" src="https://github.com/user-attachments/assets/3e5ac5a7-b129-49dc-b23a-ca6aa4355711" />
  <img width="1146" height="785" alt="image" src="https://github.com/user-attachments/assets/6aec88e9-903d-4618-988b-3c49720cd087" />
  <img width="1148" height="784" alt="image" src="https://github.com/user-attachments/assets/1fc60ef0-10d2-4ce7-8273-76628d693203" />
  <img width="1147" height="784" alt="image" src="https://github.com/user-attachments/assets/d34c767d-8be7-49eb-931d-d7bc66b43a4b" />

</p>
