namespace Fable.Import
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import.JS
open Fable.Import.Browser


module p5 =
    type [<AllowNullLiteral>] [<Import("Color","p5")>] Color() =
        class end

    and [<AllowNullLiteral>] [<Import("Element","p5")>] Element(elt: string, ?pInst: obj) =
        member __.elt with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.parent(parent: U2<string, obj>): Element = jsNative
        member __.id(id: string): Element= jsNative
        member __.mousePressed(fxn: Func<unit, obj>): Element= jsNative
        member __.mouseWheel(fxn: Func<unit, obj>): Element= jsNative
        member __.mouseReleased(fxn: Func<unit, obj>): Element= jsNative
        member __.mouseClicked(fxn: Func<unit, obj>): Element= jsNative
        member __.mouseMoved(fxn: Func<unit, obj>): Element= jsNative
        member __.mouseOver(fxn: Func<unit, obj>): Element= jsNative
        member __.changed(fxn: Func<unit, obj>): Element= jsNative
        member __.input(fxn: Func<unit, obj>): Element= jsNative
        member __.mouseOut(fxn: Func<unit, obj>): Element= jsNative
        member __.touchStarted(fxn: Func<unit, obj>): Element= jsNative
        member __.touchMoved(fxn: Func<unit, obj>): Element= jsNative
        member __.touchEnded(fxn: Func<unit, obj>): Element= jsNative
        member __.dragOver(fxn: Func<unit, obj>): Element= jsNative
        member __.dragLeave(fxn: Func<unit, obj>): Element= jsNative
        member __.child(?child: U3<string, obj, Element>): Element= jsNative
        member __.remove(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Graphics","p5")>] Graphics() =
        inherit Element("graphics")


    and [<AllowNullLiteral>] [<Import("Renderer","p5")>] Renderer() =
        inherit Element("renderer")


    and [<AllowNullLiteral>] [<Import("Image","p5")>] Image(width: float, height: float, pInst: obj) =
        member __.width with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.height with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.loadPixels(): unit = jsNative
        member __.set(x: float, y: float, a: U3<float, ResizeArray<obj>, obj>): unit = jsNative
        member __.resize(width: float, height: float): unit = jsNative
        member __.mask(srcImage: Image): unit = jsNative
        member __.save(filename: string, extension: string): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Table","p5")>] Table(?rows: ResizeArray<obj>) =
        member __.columns with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.rows with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.addRow(?row: TableRow): unit = jsNative
        member __.removeRow(id: float): unit = jsNative
        member __.getRows(): ResizeArray<obj> = jsNative
        member __.findRows(value: string, column: U2<float, string>): ResizeArray<obj> = jsNative
        member __.matchRows(regexp: string, ?column: U2<string, float>): ResizeArray<obj> = jsNative
        member __.getColumn(column: U2<string, float>): ResizeArray<obj> = jsNative
        member __.clearRows(): unit = jsNative
        member __.addColumn(?title: string): unit = jsNative
        member __.getRowCount(): float = jsNative
        member __.removeTokens(chars: string, ?column: U2<string, float>): unit = jsNative
        member __.trim(column: U2<string, float>): unit = jsNative
        member __.removeColumn(column: U2<string, float>): unit = jsNative
        member __.set(column: U2<string, float>, value: U2<string, float>): unit = jsNative
        member __.setNum(row: float, column: U2<string, float>, value: float): unit = jsNative
        member __.setString(row: float, column: U2<string, float>, value: string): unit = jsNative
        member __.get(row: float, column: U2<string, float>): U2<string, float> = jsNative
        member __.getNum(row: float, column: U2<string, float>): float = jsNative
        member __.getString(row: float, column: U2<string, float>): string = jsNative
        member __.getObject(headerColumn: string): obj = jsNative
        member __.getArray(): ResizeArray<obj> = jsNative

    and [<AllowNullLiteral>] [<Import("TableRow","p5")>] TableRow(?str: string, ?separator: string) =
        member __.set(column: U2<string, float>, value: U2<string, float>): unit = jsNative
        member __.setNum(column: U2<string, float>, value: float): unit = jsNative
        member __.setString(column: U2<string, float>, value: string): unit = jsNative
        member __.get(column: U2<string, float>): U2<string, float> = jsNative
        member __.getNum(column: U2<string, float>): float = jsNative
        member __.getString(column: U2<string, float>): string = jsNative

    and [<AllowNullLiteral>] [<Import("Vector","p5")>] Vector(?x: float, ?y: float, ?z: float) =
        member __.x with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.y with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.z with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.toString(): unit = jsNative
        member __.set(?x: U3<float, Vector, ResizeArray<obj>>, ?y: float, ?z: float): unit = jsNative
        member __.copy(): Vector = jsNative
        member __.add(x: U3<float, Vector, ResizeArray<obj>>, ?y: float, ?z: float): Vector = jsNative
        member __.sub(x: U3<float, Vector, ResizeArray<obj>>, ?y: float, ?z: float): Vector = jsNative
        member __.mult(n: float): Vector = jsNative
        member __.div(n: float): Vector = jsNative
        member __.mag(): float = jsNative
        member __.magSq(): float = jsNative
        member __.dot(x: U2<float, Vector>, ?y: float, ?z: float): float = jsNative
        member __.cross(v: Vector): Vector = jsNative
        member __.dist(v: Vector): float = jsNative
        member __.normalize(): Vector = jsNative
        member __.limit(max: float): Vector = jsNative
        member __.setMag(len: float): Vector = jsNative
        member __.heading(): float = jsNative
        member __.rotate(angle: float): Vector = jsNative
        member __.array(): ResizeArray<obj> = jsNative
        member __.equals(?x: U3<float, Vector, ResizeArray<obj>>, ?y: float, ?z: float): bool = jsNative
        static member fromAngle(angle: float): Vector = jsNative
        static member random2D(): Vector = jsNative
        static member random3D(): Vector = jsNative
        static member angleBetween(v1: Vector, v2: Vector): float = jsNative

    and [<AllowNullLiteral>] [<Import("Font","p5")>] Font(?pInst: obj) =
        member __.font with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.textBounds(line: string, x: float, y: float, fontSize: float, options: obj): obj = jsNative

    and [<AllowNullLiteral>] [<Import("MediaElement","p5")>] MediaElement(elt: string, ?pInst: obj) =
        member __.src with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.volume(?``val``: float): U2<float, MediaElement> = jsNative
        member __.duration(): float = jsNative
        member __.disconnect(): unit = jsNative
        member __.showControls(): unit = jsNative
        member __.hideControls(): unit = jsNative
        member __.addCue(time: float, callback: Func<unit, obj>, ?value: obj): float = jsNative
        member __.removeCue(id: float): unit = jsNative
        member __.clearCues(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("File","p5")>] File() =
        member __.file with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.``type`` with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.subtype with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.name with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.size with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.data with get(): obj = jsNative and set(v: obj): unit = jsNative

    and [<AllowNullLiteral>] [<Import("SoundFile","p5")>] SoundFile() =
        member __.isLoaded(): bool = jsNative
        member __.play(?startTime: float, ?rate: float, ?amp: float, ?cueStart: float, ?duration: float): unit = jsNative
        member __.playMode(str: string): unit = jsNative
        member __.pause(?startTime: float): unit = jsNative
        member __.loop(?startTime: float, ?rate: float, ?amp: float, ?cueLoopStart: float, ?duration: float): unit = jsNative
        member __.isPlaying(): bool = jsNative
        member __.isPaused(): bool = jsNative
        member __.stop(?startTime: float): unit = jsNative
        member __.setVolume(volume: U2<float, obj>, ?rampTime: float, ?timeFromNow: float): unit = jsNative
        member __.rate(?playbackRate: float): unit = jsNative
        member __.duration(): float = jsNative
        member __.currentTime(): float = jsNative
        member __.jump(cueTime: float, uuration: float): unit = jsNative
        member __.channels(): float = jsNative
        member __.sampleRate(): float = jsNative
        member __.frames(): float = jsNative
        member __.reverseBuffer(): unit = jsNative
        member __.onended(callback: Func<unit, obj>): unit = jsNative
        member __.connect(?``object``: obj): unit = jsNative
        member __.disconnect(): unit = jsNative
        member __.setPath(path: string, callback: Func<unit, obj>): unit = jsNative
        member __.processPeaks(callback: Func<unit, obj>, ?initThreshold: float, ?minThreshold: float, ?minPeaks: float): ResizeArray<obj> = jsNative
        member __.addCue(time: float, callback: Func<unit, obj>, ?value: obj): float = jsNative
        member __.removeCue(id: float): unit = jsNative
        member __.clearCues(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Amplitude","p5")>] Amplitude(?smoothing: float) =
        member __.getLevel(?channel: float): float = jsNative
        member __.toggleNormalize(?boolean: bool): unit = jsNative
        member __.smooth(set: float): unit = jsNative

    and [<AllowNullLiteral>] [<Import("FFT","p5")>] FFT(?smoothing: float, ?bins: float) =
        member __.setInput(?source: obj): unit = jsNative
        member __.waveform(?bins: float, ?precision: string): ResizeArray<obj> = jsNative
        member __.analyze(?bins: float, ?scale: float): ResizeArray<obj> = jsNative
        member __.getEnergy(frequency1: U2<float, string>, ?frequency2: float): float = jsNative
        member __.getCentroid(): float = jsNative
        member __.smooth(smoothing: float): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Signal","p5")>] Signal() =
        class end

    and [<AllowNullLiteral>] [<Import("Oscillator","p5")>] Oscillator(?freq: float, ?``type``: string) =
        member __.start(?time: float, ?frequency: float): unit = jsNative
        member __.stop(secondsFromNow: float): unit = jsNative
        member __.setType(``type``: string): unit = jsNative
        member __.connect(unit: obj): unit = jsNative
        member __.disconnect(): unit = jsNative
        member __.pan(panning: float, timeFromNow: float): unit = jsNative
        member __.phase(phase: float): unit = jsNative
        member __.add(number: float): Oscillator = jsNative
        member __.mult(number: float): Oscillator = jsNative
        member __.scale(inMin: float, inMax: float, outMin: float, outMax: float): Oscillator = jsNative

    and [<AllowNullLiteral>] [<Import("Env","p5")>] Env() =
        member __.attackTime with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.attackLevel with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.decayTime with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.decayLevel with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.releaseTime with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.releaseLevel with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.set(attackTime: float, attackLevel: float, decayTime: float, decayLevel: float, releaseTime: float, releaseLevel: float): unit = jsNative
        member __.setADSR(attackTime: float, ?decayTime: float, ?susRatio: float, ?releaseTime: float): unit = jsNative
        member __.setRange(aLevel: float, rLevel: float): unit = jsNative
        member __.setInput(unit: obj): unit = jsNative
        member __.setExp(isExp: bool): unit = jsNative
        member __.play(unit: obj, ?startTime: float, ?sustainTime: float): unit = jsNative
        member __.triggerAttack(unit: obj, secondsFromNow: float): unit = jsNative
        member __.triggerRelease(unit: obj, secondsFromNow: float): unit = jsNative
        member __.ramp(unit: obj, secondsFromNow: float, v: float, ?v2: float): unit = jsNative
        member __.add(number: float): Env = jsNative
        member __.mult(number: float): Env = jsNative
        member __.scale(inMin: float, inMax: float, outMin: float, outMax: float): Env = jsNative

    and [<AllowNullLiteral>] [<Import("Pulse","p5")>] Pulse(?freq: float, ?w: float) =
        member __.width(?width: float): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Noise","p5")>] Noise(``type``: string) =
        member __.setType(?``type``: string): unit = jsNative
        member __.start(): unit = jsNative
        member __.stop(): unit = jsNative
        member __.pan(panning: float, timeFromNow: float): unit = jsNative
        member __.connect(unit: obj): unit = jsNative
        member __.disconnect(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("AudioIn","p5")>] AudioIn() =
        member __.enabled with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.start(successCallback: Func<unit, obj>, errorCallback: Func<unit, obj>): unit = jsNative
        member __.stop(): unit = jsNative
        member __.connect(?unit: obj): unit = jsNative
        member __.disconnect(): unit = jsNative
        member __.getLevel(?smoothing: float): float = jsNative
        member __.amp(vol: float, ?time: float): unit = jsNative
        member __.getSources(callback: Func<unit, obj>): unit = jsNative
        member __.setSource(num: float): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Filter","p5")>] Filter() =
        member __.biquadFilter with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.set(freq: float, res: float, ?timeFromNow: float): unit = jsNative
        member __.freq(freq: float, ?timeFromNow: float): float = jsNative
        member __.res(res: float, ?timeFromNow: float): float = jsNative
        member __.setType(UNKNOWN: string): unit = jsNative
        member __.amp(volume: float, ?rampTime: float, ?timeFromNow: float): unit = jsNative
        member __.connect(unit: obj): unit = jsNative
        member __.disconnect(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Delay","p5")>] Delay() =
        member __.leftDelay with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.rightDelay with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.``process``(Signal: obj, ?delayTime: float, ?feedback: float, ?lowPass: float): unit = jsNative
        member __.delayTime(delayTime: float): unit = jsNative
        member __.feedback(feedback: U2<float, obj>): unit = jsNative
        member __.filter(cutoffFreq: U2<float, obj>, res: U2<float, obj>): unit = jsNative
        member __.setType(``type``: U2<string, float>): unit = jsNative
        member __.amp(volume: float, ?rampTime: float, ?timeFromNow: float): unit = jsNative
        member __.connect(unit: obj): unit = jsNative
        member __.disconnect(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Reverb","p5")>] Reverb() =
        member __.``process``(src: obj, ?seconds: float, ?decayRate: float, ?reverse: bool): unit = jsNative
        member __.set(?seconds: float, ?decayRate: float, ?reverse: bool): unit = jsNative
        member __.amp(volume: float, ?rampTime: float, ?timeFromNow: float): unit = jsNative
        member __.connect(unit: obj): unit = jsNative
        member __.disconnect(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Convolver","p5")>] Convolver(path: string, ?callback: Func<unit, obj>, ?errorCallback: Func<unit, obj>) =
        member __.convolverNode with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.impulses with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.createConvolver(path: string, ?callback: Func<unit, obj>, ?errorCallback: Func<unit, obj>): Convolver = jsNative
        member __.``process``(src: obj): unit = jsNative
        member __.addImpulse(path: string, callback: Func<unit, obj>, errorCallback: Func<unit, obj>): unit = jsNative
        member __.resetImpulse(path: string, callback: Func<unit, obj>, errorCallback: Func<unit, obj>): unit = jsNative
        member __.toggleImpulse(id: U2<string, float>): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Phrase","p5")>] Phrase(name: string, callback: Func<unit, obj>, sequence: ResizeArray<obj>) =
        member __.sequence with get(): obj = jsNative and set(v: obj): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Part","p5")>] Part(?steps: float, ?tatums: float) =
        member __.setBPM(BPM: float, ?rampTime: float): unit = jsNative
        member __.getBPM(): float = jsNative
        member __.start(?time: float): unit = jsNative
        member __.loop(?time: float): unit = jsNative
        member __.noLoop(): unit = jsNative
        member __.stop(?time: float): unit = jsNative
        member __.pause(time: float): unit = jsNative
        member __.addPhrase(phrase: Phrase): unit = jsNative
        member __.removePhrase(phraseName: string): unit = jsNative
        member __.getPhrase(phraseName: string): unit = jsNative
        member __.replaceSequence(phraseName: string, sequence: ResizeArray<obj>): unit = jsNative
        member __.onStep(callback: Func<unit, obj>): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Score","p5")>] Score() =
        member __.start(): unit = jsNative
        member __.stop(): unit = jsNative
        member __.pause(): unit = jsNative
        member __.loop(): unit = jsNative
        member __.noLoop(): unit = jsNative

    and [<AllowNullLiteral>] [<Import("SoundRecorder","p5")>] SoundRecorder() =
        member __.setInput(?unit: obj): unit = jsNative
        member __.record(soundFile: SoundFile, ?duration: float, ?callback: Func<unit, obj>): unit = jsNative
        member __.stop(): unit = jsNative
        member __.saveSound(soundFile: SoundFile, name: string): unit = jsNative

    and [<AllowNullLiteral>] [<Import("PeakDetect","p5")>] PeakDetect(?freq1: float, ?freq2: float, ?threshold: float, ?framesPerPeak: float) =
        member __.update(fftObject: FFT): unit = jsNative
        member __.onPeak(callback: Func<unit, obj>, ?``val``: obj): unit = jsNative

    and [<AllowNullLiteral>] [<Import("Gain","p5")>] Gain() =
        member __.setInput(src: obj): unit = jsNative
        member __.connect(unit: obj): unit = jsNative
        member __.disconnect(): unit = jsNative
        member __.amp(volume: float, ?rampTime: float, ?timeFromNow: float): unit = jsNative

type [<AllowNullLiteral>] [<Import("*","p5")>] p5(sketch: Func<obj, unit>, ?node: U2<HTMLElement, bool>, ?sync: bool) =
        member __.HALF_PI with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.PI with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.QUARTER_PI with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.TAU with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.TWO_PI with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.frameCount with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.focused with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.displayWidth with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.displayHeight with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.windowWidth with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.windowHeight with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.width with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.height with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.deviceOrientation with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.accelerationX with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.accelerationY with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.accelerationZ with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.pAccelerationX with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.pAccelerationY with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.pAccelerationZ with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.rotationX with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.rotationY with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.rotationZ with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.pRotationX with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.pRotationY with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.pRotationZ with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.keyIsPressed with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.key with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.keyCode with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.mouseX with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.mouseY with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.pmouseX with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.pmouseY with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.winMouseX with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.winMouseY with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.pwinMouseX with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.pwinMouseY with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.mouseButton with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.mouseIsPressed with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.touchX with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.touchY with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.ptouchX with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.ptouchY with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.touchIsDown with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.plane(width: float, height: float): p5 = jsNative
        member __.sphere(radius: float, ?detail: float): unit = jsNative
        member __.ellipsoid(radiusx: float, radiusy: float, radiusz: float, ?detail: float): p5 = jsNative
        member __.cylinder(radius: float, height: float, ?detail: float): p5 = jsNative
        member __.cone(radius: float, height: float, ?detail: float): unit = jsNative
        member __.torus(radius: float, tubeRadius: float, ?detail: float): unit = jsNative
        member __.box(width: float, height: float, depth: float): p5 = jsNative
        member __.camera(x: float, y: float, z: float): p5 = jsNative
        member __.perspective(fovy: float, aspect: float, near: float, far: float): p5 = jsNative
        member __.ortho(left: float, right: float, bottom: float, top: float, near: float, far: float): p5 = jsNative
        member __.ambientLight(v1: U4<float, ResizeArray<obj>, string, p5.Color>, ?v2: float, ?v3: float, ?a: float): p5 = jsNative
        member __.normalMaterial(): p5 = jsNative
        member __.texture(): p5 = jsNative
        member __.basicMaterial(v1: U4<float, ResizeArray<obj>, string, p5.Color>, ?v2: float, ?v3: float, ?a: float): p5 = jsNative    
        member __.ambientMaterial(v1: U4<float, ResizeArray<obj>, string, p5.Color>, ?v2: float, ?v3: float, ?a: float): p5 = jsNative
        member __.specularMaterial(v1: U4<float, ResizeArray<obj>, string, p5.Color>, ?v2: float, ?v3: float, ?a: float): p5 = jsNative
        member __.alpha(obj: obj): unit = jsNative
        member __.blue(obj: obj): unit = jsNative
        member __.brightness(color: obj): unit = jsNative
        member __.color(v1: U2<float, string>, ?v2: float, ?v3: float, ?alpha: float): ResizeArray<obj> = jsNative
        member __.green(color: obj): unit = jsNative
        member __.hue(color: obj): unit = jsNative
        member __.lightness(color: obj): unit = jsNative
        member __.red(obj: obj): unit = jsNative
        member __.saturation(color: obj): unit = jsNative
        member __.background(v1: U4<float, string, p5.Color, p5.Image>, ?v2: float, ?v3: float, ?a: float): unit = jsNative
        member __.clear(): unit = jsNative
        member __.fill(v1: U4<float, ResizeArray<obj>, string, p5.Color>, ?v2: float, ?v3: float, ?a: float): unit = jsNative
        member __.noFill(): unit = jsNative
        member __.noStroke(): unit = jsNative
        member __.stroke(v1: U4<float, ResizeArray<obj>, string, p5.Color>, ?v2: float, ?v3: float, ?a: float): unit = jsNative
        member __.arc(a: float, b: float, c: float, d: float, start: float, stop: float, ?mode: string): obj = jsNative
        member __.ellipse(a: float, b: float, c: float, d: float): p5 = jsNative
        member __.line(x1: float, y1: float, x2: float, y2: float): p5 = jsNative
        member __.point(x: float, y: float): p5 = jsNative
        member __.quad(x1: float, y1: float, x2: float, y2: float, x3: float, y3: float, x4: float, y4: float): p5 = jsNative
        member __.rect(x: float, y: float, w: float, h: float, ?tl: float, ?tr: float, ?br: float, ?bl: float): p5 = jsNative
        member __.triangle(x1: float, y1: float, x2: float, y2: float, x3: float, y3: float): p5 = jsNative
        member __.noSmooth(): p5 = jsNative
        member __.smooth(): p5 = jsNative
        member __.strokeWeight(weight: float): p5 = jsNative
        member __.preload(): unit = jsNative
        member __.setup with get(): obj = jsNative and set(v: obj): unit = jsNative  
        member __.draw  with get(): obj = jsNative and set(v: obj): unit = jsNative  
        
        //member __.setup(): unit = jsNative
        //member __.draw(): unit = jsNative
        member __.remove(): unit = jsNative
        member __.bezier(x1: float, y1: float, x2: float, y2: float, x3: float, y3: float, x4: float, y4: float): obj = jsNative
        member __.bezierPoint(a: float, b: float, c: float, d: float, t: float): float = jsNative
        member __.bezierTangent(a: float, b: float, c: float, d: float, t: float): float = jsNative
        member __.curve(x1: float, y1: float, x2: float, y2: float, x3: float, y3: float, x4: float, y4: float): obj = jsNative
        member __.curveTightness(amount: float): obj = jsNative
        member __.curvePoint(a: float, b: float, c: float, d: float, t: float): float = jsNative
        member __.curveTangent(a: float, b: float, c: float, d: float, t: float): float = jsNative
        member __.print(contents: obj): unit = jsNative
        member __.frameRate(?fps: float): float = jsNative
        member __.noCursor(): unit = jsNative
        member __.windowResized(): unit = jsNative
        member __.fullscreen(?``val``: bool): bool = jsNative
        member __.pixelDensity(?``val``: float): float = jsNative
        member __.displayDensity(): float = jsNative
        member __.getURL(): string = jsNative
        member __.getURLPath(): ResizeArray<obj> = jsNative
        member __.getURLParams(): obj = jsNative
        member __.createCanvas(w: float, h: float, ?renderer: string): obj = jsNative
        member __.resizeCanvas(): unit = jsNative
        member __.noCanvas(): unit = jsNative
        member __.createGraphics(w: float, h: float, renderer: string): obj = jsNative
        member __.noLoop(): unit = jsNative
        member __.loop(): unit = jsNative
        member __.push(): unit = jsNative
        member __.pop(): unit = jsNative
        member __.redraw(): unit = jsNative
        member __.applyMatrix(n00: float, n01: float, n02: float, n10: float, n11: float, n12: float): p5 = jsNative
        member __.resetMatrix(): p5 = jsNative
        member __.rotate(angle: float): p5 = jsNative
        member __.shearX(angle: float): p5 = jsNative
        member __.shearY(angle: float): p5 = jsNative
        member __.translate(x: float, y: float): p5 = jsNative
        member __.beginContour(): obj = jsNative
        member __.bezierVertex(x2: float, y2: float, x3: float, y3: float, x4: float, y4: float): obj = jsNative
        member __.curveVertex(x: float, y: float): obj = jsNative
        member __.endContour(): obj = jsNative
        member __.quadraticVertex(cx: float, cy: float, x3: float, y3: float): obj = jsNative
        member __.vertex(x: float, y: float): obj = jsNative
        member __.setMoveThreshold(value: float): unit = jsNative
        member __.setShakeThreshold(value: float): unit = jsNative
        member __.deviceMoved(): unit = jsNative
        member __.deviceTurned(): unit = jsNative
        member __.deviceShaken(): unit = jsNative
        member __.keyPressed(): unit = jsNative
        member __.keyReleased(): unit = jsNative
        member __.keyTyped(): unit = jsNative
        member __.keyIsDown(code: float): bool = jsNative
        member __.mouseMoved(): unit = jsNative
        member __.mouseDragged(): unit = jsNative
        member __.mousePressed(): unit = jsNative
        member __.mouseReleased(): unit = jsNative
        member __.mouseClicked(): unit = jsNative
        member __.mouseWheel(): unit = jsNative
        member __.touchStarted(): unit = jsNative
        member __.touchMoved(): unit = jsNative
        member __.touchEnded(): unit = jsNative
        member __.createImage(width: float, height: float): p5.Image = jsNative
        member __.saveFrames(filename: string, extension: string, duration: float, framerate: float, ?callback: Func<unit, obj>): unit = jsNative
        member __.image(img: p5.Image, ?sx: float, ?sy: float, ?sWidth: float, ?sHeight: float, ?dx: float, ?dy: float, ?dWidth: float, ?dHeight: float): unit = jsNative
        member __.tint(v1: U2<float, ResizeArray<obj>>, ?v2: U2<float, ResizeArray<obj>>, ?v3: U2<float, ResizeArray<obj>>, ?a: U2<float, ResizeArray<obj>>): unit = jsNative
        member __.noTint(): unit = jsNative
        member __.imageMode(m: string): unit = jsNative
        member __.filter(filterType: string, filterParam: float): unit = jsNative
        member __.get(?x: float, ?y: float, ?w: float, ?h: float): U2<ResizeArray<obj>, p5.Image> = jsNative
        member __.loadPixels(): unit = jsNative
        member __.set(x: float, y: float, c: U3<float, ResizeArray<obj>, obj>): unit = jsNative
        member __.loadFont(path: string, ?callback: Func<unit, obj>): obj = jsNative
        member __.loadJSON(path: string, ?callback: Func<unit, obj>, ?errorCallback: Func<unit, obj>, ?datatype: string): U2<obj, ResizeArray<obj>> = jsNative
        member __.loadStrings(filename: string, ?callback: Func<unit, obj>, ?errorCallback: Func<unit, obj>): ResizeArray<obj> = jsNative
        member __.loadXML(filename: string, ?callback: Func<unit, obj>, ?errorCallback: Func<unit, obj>): obj = jsNative
        member __.httpGet(path: string, ?data: obj, ?datatype: string, ?callback: Func<unit, obj>, ?errorCallback: Func<unit, obj>): unit = jsNative
        member __.httpPost(path: string, ?data: obj, ?datatype: string, ?callback: Func<unit, obj>, ?errorCallback: Func<unit, obj>): unit = jsNative
        member __.httpDo(path: string, ?``method``: string, ?data: obj, ?datatype: string, ?callback: Func<unit, obj>, ?errorCallback: Func<unit, obj>): unit = jsNative
        member __.saveJSON(json: U2<ResizeArray<obj>, obj>, filename: string, ?optimize: bool): unit = jsNative
        member __.saveStrings(list: ResizeArray<obj>, filename: string): unit = jsNative
        member __.saveTable(Table: p5.Table, filename: string, ?options: string): unit = jsNative
        member __.abs(n: float): float = jsNative
        member __.ceil(n: float): float = jsNative
        member __.constrain(n: float, low: float, high: float): float = jsNative
        member __.exp(n: float): float = jsNative
        member __.floor(n: float): float = jsNative
        member __.lerp(start: float, stop: float, amt: float): float = jsNative
        member __.log(n: float): float = jsNative
        member __.mag(a: float, b: float): float = jsNative
        member __.map(value: float, start1: float, stop1: float, start2: float, stop: float): float = jsNative
        member __.max(n0: U2<float, ResizeArray<obj>>): float = jsNative
        member __.min(n0: U2<float, ResizeArray<obj>>): float = jsNative
        member __.norm(value: float, start: float, stop: float): float = jsNative
        member __.pow(n: float, e: float): float = jsNative
        member __.round(n: float): float = jsNative
        member __.sq(n: float): float = jsNative
        member __.sqrt(n: float): float = jsNative
        member __.createVector(?x: float, ?y: float, ?z: float): unit = jsNative
        member __.noise(x: float, y: float, z: float): float = jsNative
        member __.noiseDetail(lod: float, falloff: float): unit = jsNative
        member __.noiseSeed(seed: float): unit = jsNative
        member __.randomSeed(seed: float): unit = jsNative
        member __.random(min: float, max: float): float = jsNative
        member __.randomGaussian(mean: float, sd: float): float = jsNative
        member __.acos(value: float): float = jsNative
        member __.asin(value: float): float = jsNative
        member __.atan(value: float): float = jsNative
        member __.atan2(y: float, x: float): float = jsNative
        member __.cos(angle: float): float = jsNative
        member __.sin(angle: float): float = jsNative
        member __.tan(angle: float): float = jsNative
        member __.degrees(radians: float): float = jsNative
        member __.radians(degrees: float): float = jsNative
        member __.textLeading(leading: float): U2<obj, float> = jsNative
        member __.textSize(theSize: float): U2<obj, float> = jsNative
        member __.textWidth(theText: string): float = jsNative
        member __.text(str: string, x: float, y: float, x2: float, y2: float): obj = jsNative
        member __.textFont(f: U2<obj, string>): obj = jsNative
        member __.append(array: ResizeArray<obj>, value: obj): unit = jsNative
        member __.concat(a: ResizeArray<obj>, b: ResizeArray<obj>): ResizeArray<obj> = jsNative
        member __.reverse(list: ResizeArray<obj>): unit = jsNative
        member __.shorten(list: ResizeArray<obj>): ResizeArray<obj> = jsNative
        member __.shuffle(array: ResizeArray<obj>, ?bool: bool): ResizeArray<obj> = jsNative
        member __.sort(list: ResizeArray<obj>, ?count: float): unit = jsNative
        member __.splice(list: ResizeArray<obj>, value: obj, position: float): unit = jsNative
        member __.subset(list: ResizeArray<obj>, start: float, ?count: float): ResizeArray<obj> = jsNative
        member __.float(str: string): float = jsNative
        member __.int(n: U4<string, bool, float, ResizeArray<obj>>): float = jsNative
        member __.str(n: U4<string, bool, float, ResizeArray<obj>>): string = jsNative
        member __.boolean(n: U4<string, bool, float, ResizeArray<obj>>): bool = jsNative
        member __.byte(n: U4<string, bool, float, ResizeArray<obj>>): float = jsNative
        member __.char(n: U3<string, float, ResizeArray<obj>>): string = jsNative
        member __.unchar(n: U2<string, ResizeArray<obj>>): float = jsNative
        member __.hex(n: U2<float, ResizeArray<obj>>): string = jsNative
        member __.unhex(n: U2<string, ResizeArray<obj>>): float = jsNative
        member __.join(list: ResizeArray<obj>, separator: string): string = jsNative
        member __.``match``(str: string, regexp: string): ResizeArray<obj> = jsNative
        member __.matchAll(str: string, regexp: string): ResizeArray<obj> = jsNative
        member __.nf(num: U2<float, ResizeArray<obj>>, ?left: float, ?right: float): U2<string, ResizeArray<obj>> = jsNative
        member __.nfc(num: U2<float, ResizeArray<obj>>, ?right: float): U2<string, ResizeArray<obj>> = jsNative
        member __.nfp(num: U2<float, ResizeArray<obj>>, ?left: float, ?right: float): U2<string, ResizeArray<obj>> = jsNative
        member __.nfs(num: U2<float, ResizeArray<obj>>, ?left: float, ?right: float): U2<string, ResizeArray<obj>> = jsNative
        member __.split(value: string, delim: string): ResizeArray<obj> = jsNative
        member __.splitTokens(value: string, ?delim: string): ResizeArray<obj> = jsNative
        member __.trim(?str: U2<string, ResizeArray<obj>>): U2<string, ResizeArray<obj>> = jsNative
        member __.day(): float = jsNative
        member __.hour(): float = jsNative
        member __.minute(): float = jsNative
        member __.millis(): float = jsNative
        member __.month(): float = jsNative
        member __.second(): float = jsNative
        member __.year(): float = jsNative
        member __.selectAll(name: string, ?container: string): ResizeArray<obj> = jsNative
        member __.removeElements(): unit = jsNative
        member __.getAudioContext(): obj = jsNative
        member __.getMasterVolume(): float = jsNative
        member __.masterVolume(volume: U2<float, obj>, ?rampTime: float, ?timeFromNow: float): unit = jsNative
        member __.sampleRate(): float = jsNative
        member __.midiToFreq(midiNote: float): float = jsNative

