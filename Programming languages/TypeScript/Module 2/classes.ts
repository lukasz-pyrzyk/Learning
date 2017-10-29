interface ClockInterface {
    currentTime : Date;
    setTime(d : Date);
}

class Clock implements ClockInterface{
    currentTime: Date;
    constructor(h: number, m: number) { }
    setTime(d: Date) {
        this.currentTime = d;
    }
}

interface ClockConstructor1 {
    new (hour: number, minute: number) : ClockInterface1;
}

interface ClockInterface1 {
    tick();
}

function createClock(ctor: ClockConstructor1, hour: number, minute: number): ClockInterface1 {
    return new ctor(hour, minute);
}

class DigitalClock implements ClockInterface1{
    constructor(h: number, m: number) { }
    tick() {
        console.log("beep beep");
    }
}

class AnalogClock implements ClockInterface1 {
    constructor(h: number, m: number) { }
    tick() {
        console.log("tick tock");
    }
}