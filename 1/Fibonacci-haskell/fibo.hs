fib :: Integer -> Integer
fib 0 = 0
fib 1 = 1
fib 2 = 1
fib 3 = 2
fib n = fib (n-1) + fib (n-2) + fib (n-3)

loop 0 n = return ()
loop n m = 
	do
		print(fib (m + 1))
		loop (n - 1) (m + 1) 
		return ()

main = do
  putStrLn "Ingrese n valores fibo"
  input1 <- getLine
  let temp = (read input1 :: Int)
  loop temp 0