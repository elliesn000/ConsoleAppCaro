# Console Caro Game (Gomoku)

A Console-based Caro (Gomoku) game application developed in C#. This is a personal project aimed at practicing Object-Oriented Programming (OOP) principles, designing move-finding algorithms for the AI/Bot, and implementing Entity Framework Core for data management.

---

## Project Objectives
* **OOP Practice:** Apply core principles (Encapsulation, Inheritance, Polymorphism, Abstraction) to write clean, maintainable, and scalable code (e.g., decoupling `User`, `GameLogic`, and `Bot`).
* **Algorithm Development:** Build and optimize board traversal algorithms to check for win/loss/draw conditions and compute the AI's responsive moves.
* **Data Management:** Implement database integration using the **Code First approach with Entity Framework Core**.

---

## Gameplay
1. The game is played on a fixed-size grid (e.g., 10x10).
2. On their turn, the player enters the row and column coordinates (e.g., `X, Y` or `Row, Col`) via the keyboard to place their piece.
3. The AI (Algorithm) will automatically calculate and make its move immediately after.
4. The match ends when one side successfully places 5 consecutive pieces in a horizontal, vertical, or diagonal line (without being blocked at both ends).

---

## Tech Stack
* **Language:** C# (.NET Core / .NET Console Application)
* **ORM:** Entity Framework Core (EF Core)
* **Database:** MS SQL Server

---

## Current Features & Roadmap

### Completed Features
* [x] Initialize and render an intuitive Console-based game board.
* [x] Input validation and error handling for player coordinates.
* [x] Win / Loss / Draw condition check algorithm.
* [x] AI Bot algorithm for automated move-finding and responses.

### Upcoming Features (Powered by EF Core Code First)
* [ ] **Player Profile Management:** Save player information (Name, join date, skill level).
* [ ] **Match History:** Save game statistics and re-render/replay past matches.
