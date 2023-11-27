csc /target:library -out:dll/Product.dll Product.cs
csc /target:library -out:dll/Coin.dll Coin.cs
csc /r:dll/Coin.dll /target:library -out:dll/CoinBox.dll CoinBox.cs
csc /r:dll/Coin.dll /r:dll/CoinBox.dll /r:dll/Product.dll /target:library -out:dll/VendingMachine.dll VendingMachine.cs
csc /r:dll/Coin.dll /r:dll/CoinBox.dll /r:dll/Product.dll /r:dll/VendingMachine.dll -out:dll/Machine.exe VendingMachineMenu.cs
dll/Machine.exe
