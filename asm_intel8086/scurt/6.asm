mov cx, 5
mov ax, 1
p:       
    mov dx, 2
    mul dx
    
    mov bx, 500h
    add bx, 5
    sub bx, cx
    mov ds, bx
    mov [0], ax
loop p
hlt