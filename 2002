//Задание 1
@Composable
fun Home1() {
    val participant: MutableList<String> = mutableListOf("Smith", "Johnson", "Williams", "Brown", "Jones")
    DrawParticipant(participant)
}

@Composable
fun DrawParticipant(list: MutableList<String>){
    LazyColumn (modifier = Modifier.fillMaxSize(), horizontalAlignment = Alignment.CenterHorizontally, verticalArrangement = Arrangement.Center){
        items(list.size) { index ->
            Card(modifier = Modifier.defaultMinSize(100.dp,50.dp).width(150.dp)) {
                Row(modifier = Modifier.fillMaxSize(), verticalAlignment = Alignment.CenterVertically, horizontalArrangement = Arrangement.Center) {
                    Text("${index + 1}")
                    Spacer(modifier = Modifier.width((8.dp)))
                    Text(list[index])
                }
            }
        }
    }
}

//Задание 2
fun EvenNumbers(count: Int): List<Int> {
    return List(count) { it * 2 }
}

@Composable
fun Home2() {
    EvenNumbersLazyColumn()
    //EvenNumbersColumn()
}

@Composable
fun EvenNumbersColumn() {
    val evenNumbers = EvenNumbers(100)
    Column(
        modifier = Modifier.fillMaxSize(),
        horizontalAlignment = Alignment.CenterHorizontally,
        verticalArrangement = Arrangement.Center
    ) {
        evenNumbers.forEach { number ->
            Button(onClick = { }) {
                Text(text = number.toString())
            }
        }
    }
}

@Composable
fun EvenNumbersLazyColumn() {
    var evenNumbers by remember { mutableStateOf(EvenNumbers(100)) }

    LazyColumn(
        modifier = Modifier.fillMaxSize(),
        horizontalAlignment = Alignment.CenterHorizontally,
        verticalArrangement = Arrangement.Center
    ) {
        items(evenNumbers) { number ->
            Button(
                onClick = {
                    evenNumbers = evenNumbers.filter { it != number }
                },
                modifier = Modifier.padding(8.dp)
            ) {
                Text(text = number.toString())
            }
        }
    }
}
