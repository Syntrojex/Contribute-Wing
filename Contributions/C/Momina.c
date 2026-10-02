#include <stdio.h>
#include <stdlib.h>

int main() {
    int capacity = 2; // Initial capacity
    int size = 0;     // Current number of elements
    
    // Allocate initial memory for the array
    int* arr = (int*)malloc(capacity * sizeof(int));
    if (arr == NULL) {
        printf("Memory allocation failed!\n");
        return 1;
    }

    // Add elements (grow array automatically when full)
    for (int i = 0; i < 5; i++) {
        if (size >= capacity) {
            capacity *= 2; // Double the capacity
            int* temp = (int*)realloc(arr, capacity * sizeof(int));
            if (temp == NULL) {
                printf("Memory reallocation failed!\n");
                free(arr);
                return 1;
            }
            arr = temp; // Update pointer to new resized memory block
            printf("Array regrown! New capacity: %d\n", capacity);
        }
        
        arr[size] = (i + 1) * 10; // Assign value
        size++;
    }

    // Print final array elements
    printf("Final array elements: ");
    for (int i = 0; i < size; i++) {
        printf("%d ", arr[i]);
    }
    printf("\n");

    // Free allocated memory
    free(arr);
    return 0;
}
