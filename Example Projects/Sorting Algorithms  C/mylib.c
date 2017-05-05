#include <stdio.h> /* for fprintf */
#include <stdlib.h> /* for size_t, malloc, realloc, exit */
#include "mylib.h"
void *emalloc(size_t s) {
    void *result = malloc(s);
    if (NULL == result) {
        fprintf(stderr, "Can't allocate memory\n");
        exit(EXIT_FAILURE);
    }
    return result;
}

void *erealloc(void *p, size_t s) {
    void *temp = realloc(p, s);

    if(NULL == temp){
        fprintf(stderr, "Can't alocate memory\n");
        exit(EXIT_FAILURE);
    }
    return temp;
}
