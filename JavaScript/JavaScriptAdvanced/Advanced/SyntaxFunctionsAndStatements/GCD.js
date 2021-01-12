function GCD(a, b){

    if (b > a) {
        var local = a; 
        a = b; 
        b = local;
    };

    while (true){
        if (b == 0){ 
            console.log(a)
            return;
        };
    
        a %= b;
    
        if (a == 0){ 
            console.log(b)
            return;
        };
    
        b %= a;
    }
}

GCD(2154, 458);