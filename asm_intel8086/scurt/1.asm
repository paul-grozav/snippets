mov ax, 5
mov bx, 3

mov cx, 500h
mov ds, cx
mov [0], ax
add [0], bx

mov [1], ax
sub [1], bx

mul bx
mov [2], ax
mov ax, 5

div bx
mov [3], ax
mov [4], dx

hlt