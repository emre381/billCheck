Bu C# programı bir restoran sipariş sistemini simüle etmektedir. Kullanıcı belirli menü öğelerini seçtikçe, siparişlerin toplam ücreti hesaplanır ve son olarak toplam tutar ekrana yazdırılır. Programın çalışmasını açıklayan bir **README** dosyası aşağıda yer almaktadır:

---

# CheckSystem - Restaurant Ordering Program

### Overview

This simple console-based application allows the user to place orders from a predefined menu, with each item having a specified price. As the user selects menu items, the total bill is updated, and the user can see the running total of their orders. The program continues accepting orders until the user decides to exit. At the end, the final bill is displayed.

### Menu Options:

1. **Adana** - $15
2. **Beyti** - $18.45
3. **Döner** - $12.75
4. **Coke** - $1
5. **Soup** - $5
6. **Exit the program** - Terminates the ordering process.

### How it works:

- When the program starts, the menu is displayed, and the user is prompted to pick an order by entering the corresponding number.
- The selected item's price is added to the total bill, and the updated bill is displayed after each selection.
- The user can keep adding items to their order until they choose option **6** to exit.
- Once the user exits, the program displays the final bill and terminates.

### Example Run:

```
1.Order is Adana 15$
2.Order is Beyti 18.45$
3.Order is Döner 12.75$
4.Order is Coke 1$
5.Order is Soup 5$
Leave with press 6
Plsease pic an order
```

The user inputs **1** to order Adana:

```
last check = 15
```

The user inputs **4** to order Coke:

```
last check = 16
```

The user inputs **6** to exit the ordering system:

```
Order is done
bill is = 16
```

### Code Walkthrough:

1. **Menu Display and Input**: A `do-while` loop is used to repeatedly display the menu and prompt the user for an order.
   
2. **Order Handling**: The program uses a `switch` statement to handle the user’s input. Each case adds the respective item’s price to the `toplam` (total) variable.

3. **Exit Condition**: If the user selects **6**, the program exits the loop and prints the final bill.

### Future Improvements:

- Validate user input to handle non-integer inputs.
- Allow users to remove items from their order.
- Add functionality for discounts or taxes.

---

Bu README dosyası, kodun nasıl çalıştığını ve temel işlevlerini açıklamaktadır. Program, kullanıcının basit bir menü üzerinden sipariş vermesine ve toplamı görmesine olanak sağlar.
