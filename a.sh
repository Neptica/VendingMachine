#!/bin/bash

# mcs /target:library -out:dll/Product.dll Product.cs
# mcs /target:library -out:dll/Coin.dll Coin.cs
# mcs /r:dll/Coin.dll /target:library -out:dll/CoinBox.dll CoinBox.cs
# mcs /r:dll/Coin.dll /r:dll/CoinBox.dll /r:dll/Product.dll /target:library -out:dll/VendingMachine.dll VendingMachine.cs
# mcs /r:dll/Coin.dll /r:dll/CoinBox.dll /r:dll/Product.dll /r:dll/VendingMachine.dll -out:dll/Machine.exe VendingMachineMenu.cs
# mono dll/Machine.exe

# Slower, but if mcs doesn't work use this for starting the application in the terminal.

csc /target:library -out:dll/Product.dll Product.cs
csc /target:library -out:dll/Coin.dll Coin.cs
csc /r:dll/Coin.dll /target:library -out:dll/CoinBox.dll CoinBox.cs
csc /r:dll/Coin.dll /r:dll/CoinBox.dll /r:dll/Product.dll /target:library -out:dll/VendingMachine.dll VendingMachine.cs
csc /r:dll/Coin.dll /r:dll/CoinBox.dll /r:dll/Product.dll /r:dll/VendingMachine.dll -out:dll/Machine.exe VendingMachineMenu.cs
mono dll/Machine.exe
