# OldPhone Keypad Processor

## Overview

This project simulates the functionality of an **old mobile phone keypad**, where users can input letters by pressing numeric keys multiple times.

## Folder Structure

- **`app/`**: Contains the main functionality of the Old Phone message processing system, including the classes that simulate the behavior of an old phone, message input, and processing.
  
- **`app.Tests/`**: Contains unit tests for the `Processor` class. These tests ensure the correct functionality of the message processing system by verifying various cases of input and output.

## Features

1. `*` to delete the last character.
2. `#` to finalize the message.
3. `2 - 9` to type letter.
4. `' '` to confirm a letter without going to the next letter.
---

## Classes and Responsibilities

### 1. `Button`  
Represents a single button on the keypad.

- **Properties**:  
   - `Digit` : The numeric digit (e.g., `2`).  
   - `Alphabet`: The sequence of letters mapped to the button (e.g., `"ABC"`).  

- **Method**:  
   - `GetLetter(int count)` : Returns the letter based on the number of key presses.

---

### 2. `OldPhone`  
Represents the phone keypad and manages the buttons.
- **Properties**:
   - `Dictionary<char, Button> KeyPad`: Stores the digit with its corresponding button.
- **Methods**:  
   - `InsertButton(char digit, string alphabet)` : Adds a new button.  
   - `RemoveButton(char digit)` : Removes a button.  
   - `GetLetter(char digit, int count)` : Gets the corresponding letter.

---

### 3. `Processor`  
Processes input strings and builds a message.

- **`ProcessInput(String input)` Methods**:  
    - The method loops through each character in the input string:
    - If the character is #, the current character is finalized, and the loop breaks.
    - If the character is *, the last character is deleted, and the state is reset.
    - If the character is a space ' ', the current character is appended, and the state is reset.
    - If the same key is pressed consecutively, the count is increased.
    - If the key changes, the previous character is appended to the message, and the state is reset for the new key.

---

### 4. `Program`  
The entry point of the application.

- Reads input from the user.  
- Uses `Processor` to process key inputs.  
- Displays the final output message.
