# C# OOP Assignment: Fantasy Combat System

## Overview

Build a turn-based combat system for a fantasy game that demonstrates inheritance, polymorphism, and interfaces. You'll create different character types that can attack each other using various abilities.

## Requirements

### 1. Core Interface

Create an `ICombatant` interface with:

-   Properties: `Name`, `Health`, `MaxHealth`, `IsAlive`
-   Methods: `Attack(ICombatant target)`, `TakeDamage(int amount)`, `DisplayStatus()`

### 2. Base Class

Create an abstract `Character` class that implements `ICombatant`:

-   Include a constructor that sets name and max health
-   Implement common functionality (TakeDamage, DisplayStatus, IsAlive logic)
-   Add an abstract method `CalculateAttackDamage()` that derived classes must implement
-   Add a virtual method `SpecialAbility(ICombatant target)` with a default implementation

### 3. Derived Character Classes

Implement at least three character types (e.g., Warrior, Mage, Rogue):

-   Each should override `CalculateAttackDamage()` with unique logic
-   At least two should override `SpecialAbility()` with unique behaviors
-   Each should have at least one unique property (e.g., Mage has `ManaPoints`, Warrior has `ArmorRating`)

### 4. Enemy Class

Create a `Monster` class that also implements `ICombatant`:

-   Should NOT inherit from `Character`
-   Has simpler behavior than player characters
-   Demonstrates that multiple unrelated classes can implement the same interface

### 5. Combat Manager

Create a `CombatManager` class with:

-   A method that accepts any `ICombatant` and displays their status (demonstrating polymorphism)
-   A method that simulates a turn of combat between two `ICombatant` objects
-   Should work with any combination of Characters and Monsters

### 6. Main Program

In your `Main` method:

-   Create instances of each character type and at least one monster
-   Store them in a collection of type `ICombatant` or `List<ICombatant>`
-   Simulate several rounds of combat using your CombatManager
-   Demonstrate polymorphic behavior by calling methods on the interface/base class references

## Bonus Challenges (Optional)

-   Add a `IHealable` interface with a `Heal()` method and implement it on appropriate classes
-   Create a character class that has both offensive and healing abilities
-   Add status effects (poisoned, strengthened, etc.) using another interface or property

## What You'll Demonstrate

-   **Inheritance**: Character classes inheriting from an abstract base
-   **Polymorphism**: Treating different character types through common interfaces/base classes
-   **Interfaces**: Multiple classes implementing ICombatant, possibly IHealable
-   **Abstract classes**: Character class with abstract and virtual methods
-   **Proper OOP design**: Encapsulation, appropriate use of access modifiers

## Tips

-   Start with the interface and base class, then build up
-   Test each class individually before integrating
-   Use meaningful names and keep methods focused
-   Don't overthink the combat math—simple calculations are fine

## Estimated Time

2-3 hours

## Getting Started

1. Create a new C# Console Application project
2. Start by defining the `ICombatant` interface
3. Build the abstract `Character` class
4. Create your derived character classes one at a time
5. Implement the `Monster` class
6. Build the `CombatManager`
