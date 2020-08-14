mov ax, 501h
mov ds, ax
mov [0], 2
mov ax, 502h
mov ds, ax
mov [0], 3
mov ax, 503h
mov ds, ax
mov [0], 4
mov ax, 504h
mov ds, ax
mov [0], 5
mov ax, 505h
mov ds, ax
mov [0], 8

mov bx, 2
mov cx, 5
p:
    mov ax, 500h
    add ax, cx
    mov ds, ax
    mov ax, [0]
    mul bx
    mov [0], ax
loop p