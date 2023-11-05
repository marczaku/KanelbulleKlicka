# Design Pattern Course

## Deliverable
- Group Project (Teams of 4)
  - GitHub Classroom
  - Any Type of Game
  - C++ Console Application
  - Using SDL Framework
    - It is extremely low-level
    - requires an object-oriented wrapper around the framework
  - Recommended: Using Windows + Rider or Visual Studio and MSBuild
  - Alternative: Using any OS + CLion and CMake
- Presentation (one per team)
  - 5 Minutes
- Documentation in your `README.md`
  - Project Description
  - Design Patterns
    - Which ones were used?
    - What do they do?
    - Why were they chosen?
    - How were they implemented?
  - 2 Screenshots
  - 1 Gameplay Video (minimum 10 seconds)

## Grading Criteria

Note: The lecturer reserves the right to disqualify Design Patterns, for example:
- if the Pattern is considered given by the Framework rather than implemented by the group.
  - e.g.: SDL already provides Double-Buffering
- or if the Pattern is considered to be implemented in a very incomplete way
  - e.g.: defining a simple `while` loop as Update Pattern.
  - or a `static` or global variable as a Singleton.

If unsure, use the Mentoring Time to find out, whether your chosen solution qualifies

### Passing
- Delivered a Visual Result
  - Including things that Update (e.g. move)
  - And Input (e.g. key press or mouse)
- Presented Results or Recorded Presentation
- Documented the Results
- Implemented at least 2 Design Patterns

### Excellent
- Delivered a Playable Game
- Implemented at least 4 Design Patterns

## Week 1

### Monday: Introduction & Assignment Set-Up (6h)

#### Introduction

- Architecture
- Performance

#### Programming Principles

- DRY
- SOLID
- KISS
- YAGNI

#### Sequencing Patterns

- Double Buffer
- Game Loop
- Update Method
- (Iterator)

### Tuesday: Workshop on Optimization Patterns in Unity (6h)
- Flyweight
- Object Pool
- Spatial Partition
- Dirty Flag

### Wednesday: MVP Design Patterns (6h)

#### Architectural (Decoupling) Patterns
- MVC
- Component
- Subclass Sandbox
- Event Bus (Queue)

#### Behavioral Patterns Part 1
- Command
- Observer
- State

#### Creational Patterns Part 1
- Singleton
- Factory
- Prototype

## Week 2

### Monday: Workshop on Structural Patterns in Unity (6h)

#### Structural Patterns
- Adapter
- Facade
- Decorator

#### Project Mentoring
- Receive help on whatever you need

### Tuesday: Workshop on Structural Patterns in C++ (6h)

#### Structural Patterns
- Composite
- Proxy
- Bridge

#### Project Mentoring
- Receive help on whatever you need

### Thursday: Project Mentoring (3h)
- Receive help on whatever you need

## Week 3

### Monday: The remaining patterns (6h)

#### Behavioral
- Visitor
- Interpreter (Bytecode)
- Strategy
- Template Method
- Chain of Responsibility
- Mediator
- Memento

#### Creational
- Type Object
- Service Locator
- Builder

### Tuesday: Project Mentoring (3h)
- Receive help on whatever you need

### Friday: Project Presentations (3h)
- 5 minute slots
- Present your results
- Name, which design patterns you have implemented

## Design Pattern Overview

- GPP (C++): Game Programming Patterns (C++)
- H-F (Java): Head-First Design Patterns (Java)
- U (C#): Unity: Level Up your Code with Game Programming Patterns (C#)
- GDP (C#): Game Development Patterns with Unity 2021 (C#)
- GDP (C++): Game Development Patterns and Best Practices (C++)
- RG: Refactoring Guru

| Pattern                 | Type          | GPP (C++) | H-F (Java) | U (C#) | GDP (C#) | GDP (C++) | RG | MZ  |
|-------------------------|---------------|-----------|------------|--------|----------|-----------|----|-----|
| **State**               | Behavioral    | ✅         | ✅          | ✅      | ✅        | ✅         | ✅  | ✅   |
| **Command**             | Behavioral    | ✅         | ✅          | ✅      | ✅        | ✅         | ✅  | ✅   |
| **Observer**            | Behavioral    | ✅         | ✅          | ✅      | ✅        | ✅         | ✅  | ✅   |
| **Singleton**           | Creational    | ✅         | ✅          | ✅      | ✅        | ✅         | ✅  |  |
| **Flyweight**           | Optimization  | ✅         | ✔️        | ✔️    |          | ✅         | ✅  | ✅   |
| **Object Pool**         | Optimization  | ✅         |            | ✅      | ✅        | ✅         |    | ✅   |
| **Factory**             | Creational    |           | ✅          | ✅      |          | ✅         | ✅  | ✅   |
| **Prototype**           | Creational    | ✅         | ✔️        |        |          | ✅         | ✅  | ✅   |
| **Adapter**             | Structural    |           | ✅          | ✔️    | ✔️      |           | ✅  | ✅   |
| **Facade**              | Structural    |           | ✅          |        | ✔️      |           | ✅  | ✅   |
| **Decorator**           | Structural    |           | ✅          |        | ✅        |           | ✅  |     |
| **MVC (MVP)**           | Architectural |           | ✅          | ✅      |          |           |    | ✅   |
| **Event Bus (Queue)**   | Architectural | ✅         |            |        | ✅        |           |    | ✅   |
| **Component**           | Architectural | ✅         |            |        |          | ✅         |    | ✅   |
| Visitor                 | Behavioral    |           | ✔️        |        | ✅        |           | ✅  |     |
| **Iterator**            | Sequencing    |           | ✅          |        |          |           | ✅  | ✔️ |
| **Composite**           | Structural    |           | ✅          |        |          |           | ✅  | ✔️ |
| Interpreter (Bytecode)  | Behavioral    | ✅         | ✔️        | ✔️    |          |           |    |     |
| Type Object             | Creational    | ✅         |            | ✔️    |          |           |    | ✔️ |
| **Double Buffer**       | Sequencing    | ✅         |            | ✔️    |          |           |    | ✔️ |
| Service Locator         | Creational    | ✅         |            |        | ✔️      |           |    | ✔️ |
| **Dirty Flag**          | Optimization  | ✅         |            | ✔️    |          |           |    | ✔️ |
| Strategy                | Behavioral    |           |            |        | ✅        |           | ✅  |     |
| **Spatial Partition**   | Optimization  | ✅         |            |        | ✅        |           |    |     |
| Template Method         | Behavioral    |           | ✅          |        |          |           | ✅  |     |
| **Proxy**               | Structural    |           | ✅          |        |          |           | ✅  |     |
| **Game Loop**           | Sequencing    | ✅         |            |        |          |           |    | ✔️ |
| **Update Method**       | Sequencing    | ✅         |            |        |          |           |    | ✔️ |
| **Subclass Sandbox**    | Architectural | ✅         |            | ✔️    |          |           |    |     |
| **Bridge**              | Structural    |           | ✔️        |        |          |           | ✅  |     |
| Builder                 | Creational    |           | ✔️        |        |          |           | ✅  |     |
| Chain of Responsibility | Behavioral    |           | ✔️        |        |          |           | ✅  |     |
| Mediator                | Behavioral    |           | ✔️        |        |          |           | ✅  |     |
| Memento                 | Behavioral    |           | ✔️        |        |          |           | ✅  |     |
| **Data Locality**       | Optimization  | ✅         |            |        |          |           |    |     |
