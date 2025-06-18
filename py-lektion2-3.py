# Linjär sökning
def linear_search(lst, target):
    for i in range(len(lst)):
        if lst[i] == target:
            return i
    return -1

# Binär sökning (för sorterade listor)
def binary_search(lst, target):
    low = 0
    high = len(lst) - 1
    while low <= high:
        mid = (low + high) // 2
        if lst[mid] == target:
            return mid
        elif lst[mid] < target:
            low = mid + 1
        else:
            high = mid - 1
    return -1

# Bubble sort (egen sorteringsalgoritm)
def bubble_sort(lst):
    for i in range(len(lst)):
        for j in range(0, len(lst) - i - 1):
            if lst[j] > lst[j + 1]:
                lst[j], lst[j + 1] = lst[j + 1], lst[j]
    return lst

# ----- Testa funktionerna -----

# Testa linjär sökning
names = ["Anna", "Bo", "Cleo"]
print("Linjär sökning efter 'Bo':", linear_search(names, "Bo"))  # 1
print("Linjär sökning efter 'Zoe':", linear_search(names, "Zoe"))  # -1

# Testa binär sökning
numbers = [3, 6, 9, 12, 15]
print("Binär sökning efter 12:", binary_search(numbers, 12))  # 3
print("Binär sökning efter 5:", binary_search(numbers, 5))    # -1

# Inbyggd sortering
nums = [5, 3, 9, 1]
nums.sort()  # sorterar direkt
print("Inbyggd sortering:", nums)

names_unsorted = ["Zara", "Adam", "Lilly"]
sorted_names = sorted(names_unsorted)  # ny sorterad lista
print("Sorterade namn:", sorted_names)

# Bubble sort
unsorted = [9, 3, 7, 1]
sorted_list = bubble_sort(unsorted.copy())
print("Bubble sort:", sorted_list)
