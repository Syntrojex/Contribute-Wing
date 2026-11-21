#include <algorithm>
#include <iostream>
#include <vector>

int main() {
    int n = 0;
    std::cout << "Enter the number of elements: ";
    if (!(std::cin >> n) || n <= 0) {
        std::cout << "Please enter a positive integer.\n";
        return 1;
    }

    std::vector<int> arr(n);
    std::cout << "Enter " << n << " integers:\n";
    for (int i = 0; i < n; ++i) {
        if (!(std::cin >> arr[i])) {
            std::cout << "Invalid input.\n";
            return 1;
        }
    }

    std::sort(arr.begin(), arr.end());

    std::cout << "Array in ascending order:\n";
    for (int i = 0; i < n; ++i) {
        std::cout << arr[i] << (i + 1 < n ? " " : "\n");
    }

    return 0;
}
