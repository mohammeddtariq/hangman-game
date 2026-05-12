# Hangman Game

A classic Hangman game built with C# Windows Forms. The player guesses a hidden word one letter at a time — the hangman drawing gets filled in with each wrong guess.

---

## How it works

The game picks a random word from one of four categories: **Fruits**, **Animals**, **Countries**, or **Random Objects**. Each category has around 40-50 words. The hidden word is shown as blanks and the player clicks alphabet buttons to guess letters.

- 6 wrong guesses and the game is over
- Correct guesses fill in the blanks
- The hangman is drawn step by step using GDI+ graphics as lives run out
- Win or lose, the answer is revealed and you can start a new game

---

## Features

- 4 word categories with large word banks
- Clickable A–Z alphabet buttons (disabled after being guessed)
- Live hangman drawing updates with every wrong guess
- Tracks remaining lives
- Clean Windows Forms UI

---

## Tech

- C# (.NET Framework)
- Windows Forms
- GDI+ for drawing the hangman figure

---

## How to run

Open `Hangmangame.sln` in Visual Studio and run the project. No extra dependencies needed.
