
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define ARRAY_MAX 30000

/*Method called insertion-sortthat takes an array and sorts it uing
  insertion sort technique.
  @param int *a pointer to an array
  @param int n the length of a partiular array*/
void insertion_sort(int *a, int n) {
    int i;
    int j;
    int temp;
    
    
    
    for(i = 1; i < n; i++){
        
        temp = a[i];
        
        j = i - 1;
        
        while((temp < a[j]) && ( j >= 0)){
            
            a[j+1] = a[j];
            
            j = j-1;
        }
        a[j+1] = temp;
    }
      

    

    
}
/*Main method that calls the insertion-sort method on my_array while also
  implementing the clock function.
  @param void 
*/
int main(void) {
    
    int my_array[ARRAY_MAX];
    clock_t start, end;
    int i, count = 0;
    
    while (count < ARRAY_MAX && 1 == scanf("%d", &my_array[count])) {
        count++;
    }

    start = clock();
    insertion_sort(my_array, count);
    end = clock();
    
    for (i = 0; i < count; i++) {
        printf("%d\n", my_array[i]);
    }

    fprintf(stderr, "%d %f\n", count, (end - start) / (double)CLOCKS_PER_SEC);
    return EXIT_SUCCESS;
}

