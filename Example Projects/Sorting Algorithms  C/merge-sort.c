#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define ARRAY_MAX 100000


void merge(int *a, int *w, int n){
    int i;
    int j;
    int temp;
    i = 0;
    j = n/2;
    temp = 0;
    
    while (i < (n/2) && j < n){
        if(a[i] > a[j]){
            w[temp] = a[j];
            j++;
            temp++;
               
        }else{
            w[temp] = a[i];
            i++;
            temp++;
        }

    }
    while ( i < (n/2)){
        w[temp] = a[i];
        i++;
        temp++;
    }
    while (j < n){
        w[temp] = a[j];
        j++;
        temp++;  
        
    }
}

void merge_sort(int *a, int *w, int n){

    int i, j;
    i = n/2;
    j = (n - (n/2));
    if(n < 2){
        return;
    }
    merge_sort(a, w, i);
    merge_sort((a + (n/2)), w, j);

    merge(a, w, n);

    for(i = 0; i < n; i++){
        a[i] = w[i];
        

    }
}
    

    


int main(void){

    int my_array[ARRAY_MAX];
    clock_t start, end;
    int i, count = 0;
    int workSpace[ARRAY_MAX];

    while (count < ARRAY_MAX && 1 == scanf("%d", &my_array[count])) {
        count++;
    }
    start = clock();
    merge_sort(my_array, workSpace, count);
    end = clock();


    for (i = 0; i < count; i++){
        printf("%d\n", my_array[i]);
    }
    fprintf(stderr, "%d %f\n", count, (end - start) / (double)CLOCKS_PER_SEC);
    return EXIT_SUCCESS;
}
            
