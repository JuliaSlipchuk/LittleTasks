### Peaceful tours
Recall that the tour is a chess piece that goes vertically and horizontally.
We shall call the arrangement of k white and l black tours on a board of size m × n peaceful, if no tour threatens tours of a different color.
For the given m, n, k and l, find the number of peaceful tour arrangements on the board.
Incoming data
The input file contains four integers: m, n, k and l (2 ≤ m, n ≤ 10, 1 ≤ k, 1 ≤ l, k + l ≤ m · n).
Output data
Print one integer - the number of peaceful k k white and l black tours on the m × n board.
### Game with switches
There are an infinite number of lamps that are off. At each stage of the game, all those lamps whose numbers are multiples of the number of the stage of the game are switched on (if they were switched off) or off (if they were switched on).
Determine the status of the nth lamp after the nth stage of the game.
Incoming data
The first line contains the number of tests t (1 ≤ t ≤ 10). The following is t lines with the number n (0 <n ≤ 105) of the game stage.
Output data
Output t lines with states of corresponding lamps: 0 - lamp off, 1 - on.
### Crossing Game
The strip of paper is divided into n cells. Two players take turns selecting and striking out exactly k empty adjacent cells. The one who makes the last move wins. Both players follow the right strategy. The game situation is given. It is necessary to determine who wins.
Incoming data
The first line contains the numbers n and k (1 ≤ k ≤ n ≤ 40), the second line contains n characters: the Latin big O is the empty cell, the Latin big X is the crossed out cell.
Output data
Output a single number: 1 - if the one who makes the move wins first; 2 - if the second wins; 0 - if the move is impossible.
### CDs
Clean CDs come in three different packaging types. A pack of 100 disks costs 100 UAH, of 20 disks - 30 UAH, and one separate disc costs 2 UAH. What is the minimum amount needed to buy n such drives?
Incoming data
Number of n (n ≤ 1000) disks to buy.
Output data.
The minimum amount required to purchase.
### Cycle offsets
We write an integer decimal n in the binary system and form all left cyclic shifts of the number n, at which the first digit of the number is transferred to the end of the number.
For example, if n = 11, there will be 1011 in the binary system, its cyclic shifts are: 0111, 1110, 1101, 1011. The maximum value of m of all the numbers thus obtained will be 11102 = 1410.
Incoming data
The singular number is n (1 ≤ n ≤ 2 · 109).
Output data
Search number m.
### Two circles
Determine how many points intersect two circles.
Incoming data
6 numbers x1, y1, r1, x2, y2, r2, where x1, y1, x2, y2, are the coordinates of the centers of circles, r1, r2 are their radii. All numbers are valid, do not exceed 1 billion modules, and are not more than 3 decimal places.
Output data
Number of intersection points. If the intersection points are infinitely many, then print -1.
### Roman numerals
Calculate the sum of two positive integers A and B recorded in the Roman numeral system. Write down the answer also in the Roman numeral system.
M = 1000, D = 500, C = 100, L = 50, X = 10, V = 5, I = 1 (All numbers are less than 2000).
Incoming data
The line contains two numbers with the Roman number system, between which there is a + sign.
Output data
One number, the sum of numbers is also the Roman numeral system. The numbers in the Roman numeral system are written in large Latin letters.
### Sponsor word
At the end of the New Year's Eve, the sponsor decided to send m prizewinners gifts by mail. Knowing the number of participants n and the time of mail delivery between some offices of Ukrposhta, find out how long the last of the winners will receive their prize.
Incoming data
The first line contains 3 numbers: the number of tournament participants n, the number of sponsor prizes m, and the number of known delivery times between some of the k offices. The following line lists the runner-up entries through the space.
The following are k lines of 3 numbers in a row with information about known delivery times between some of the outlets in the format: a b t, where a and b are the numbers of the outlets, t (0 ≤ t ≤ 365) - the time of delivery of mail between them. The last line is the only number - the post office number from which the sponsor will send gifts. It is known that 1 ≤ n, m, a, b ≤ 365.
Output data
If all the prizes are delivered to the participants, the first line "** The good sponsor! **" will be displayed, and then, after which the last of the winners will receive their prize. If at least one participant fails to win the prize, it will print "** It is not fault of sponsor ... **" in a single line. Express phrases without quotation marks.
### Dijkstra algorithm
An oriented weighted graph is given. Find the shortest distance from vertex s to vertex f.
Incoming data
The first line contains three numbers n, s and f (1 ≤ n ≤ 100, 1 ≤ s, f ≤ n), where n is the number of vertices of the graph. The following n lines contain n numbers - adjacency matrix of the graph, where the number in the i-th row and the j-th column corresponds to the edge from i to j: -1 denotes the absence of an edge between vertices, and an arbitrary non-negative number - the presence of an edge of a given balance. Zeros are always written on the main diagonal of the matrix.
Output data
Output the required distance or -1 if no path exists between given vertices.
### Traffic lights
In the dungeon of m tunnels and n intersections, each tunnel connects two intersections. The mouse king decided to put a traffic light in each tunnel before each intersection. Write a program that calculates how many traffic lights should be installed at each intersection. Intersections are numbered from 1 to n.
Incoming data
The first line contains two numbers n and m (0 <n ≤ 100, 0 ≤ m ≤ n · (n - 1) / 2). The following m lines contain two integers i and j (1 ≤ i, j ≤ n), which mean that the intersections i and j are connected by a tunnel.
Output data
Print n numbers: The k-number indicates the number of traffic lights at the k-th intersection.
We can assume that arbitrary two intersections are connected by no more than one tunnel. There are no tunnels from and to the intersection.
### Garland
The Christmas tree is decorated with a garland of infinite length, consisting of series of connected bulbs. When the garland is switched on, only the first light comes on, counting from a switch that lights for one second. Then the garland flashes according to this rule. Every second, a condition is checked for each light bulb: if exactly one of its adjacent light bulbs is lit, then that light will burn for the next second; otherwise - it will not burn. The first light bulb has only one neighbor.
Write a program that finds, by the number of seconds, the number of garland bulbs that will burn during that second.
Incoming data
One integer n (1 ≤ n ≤ 109) is the number of the second.
Output data
Output One integer - the number of light bulbs that will burn per second n.
