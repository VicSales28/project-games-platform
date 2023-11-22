# Project Games Platform 🎮

The code implements a game platform. Functionalities have been added to include new players, game studios, and games in the database through interactions with the Console. Additionally, functionalities have been created to search for games developed by a specific studio, find games played and owned by a player, get detailed information about games and studios, and list different types of registered games. The code uses efficient LINQ queries.

Deadline: Dec 7, 2023 at 2:00 pm

<details>
 <summary><strong>🏗 Project structure</strong></summary><br />
  
The files that were changed during the development were:

- `src/TrybeGames/Controllers/TrybeGamesController.cs`: Implemented AddPlayer(), AddGameStudio() and AddGame().
- `src/TrybeGames/Database/TrybeGamesDatabase.cs`: Implemented GetGamesDevelopedBy(), GetGamesPlayedBy(), GetGamesOwnedBy(),  GetGamesWithStudio(), GetGameTypes() and GetStudiosWithGamesAndPlayers().

</details>

<details>
 <summary><strong>🖥 To access</strong></summary><br />
  
1 - Clone the repository:
`git clone git@github.com:VicSales28/project-games-platform.git`

2 - Go to the repository folder you just cloned:
`cd acc-elective-csharp-0x-project-trybe-games`

3 - Install dependencies:
- Go to the src/ folder.
- Run the command: `dotnet restore`
  
</details>

<details>
 <summary><strong>🧪 Running all tests</strong></summary><br />
 
To run the tests with .NET, run the command inside your project directory src/:
`dotnet test`
</details>

<details>
  <summary><strong>🗣 Feedbacks</strong></summary>
Give me feedbacks, I'm open to new ideas 😉
</details>
