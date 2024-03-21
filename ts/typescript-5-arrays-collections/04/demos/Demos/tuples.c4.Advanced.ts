// Creating Tuple types. 

type Game = [string, number, string?]; // name of the game, year it came out, platform when released
type Player = [string, Game]; // name of player, favorite game (nested tuple)

let games: Game[] = [
  ["The Oregon Trail", 1981, "MS DOS"],
  ["Pong", 1972, "Atari"],
  ["Tetris", 1985]
];

let player: Player = ["Jill Gundersen", games[2]];

let players: Player[] = [
    ['Jill Gundersen', games[2]],
    [games[1], 'John Smith'] // wrong type for the declared tuple
]



// destruct a tuple
let game: [string, number, string] = ["The Oregon Trail", 1981, "MS DOS"];

let [gameName, gameYear, gamePlatform] = game; // desctructing

console.log(gameName, typeof gameName);

