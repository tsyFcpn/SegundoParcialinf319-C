object Fibo {
    def recursiveFibo(n:Int):Int = {
        if (n == 0) {
            0
        } else if (n == 1) {
            1
        } else if (n == 2) {
            1
        } else if (n == 3) {
            2
        } else {
            (recursiveFibo(n - 1) + recursiveFibo(n - 2) + recursiveFibo(n - 3))
        } 
    }
    def main(args: Array[String]):Unit = {
        println("Ingrese n: ")
        val temp = scala.io.StdIn.readInt()
        for( i <- 0 to (temp - 1)){
            recursiveFunc(i)
        }
    }   
}