<h1>Introduction</h1>
This web app performs and visualizes some of the Rubik's Cube moves as defined in https://rubiks-cube-solver.com/. 

<h1>Platform</h1>
C# .Net Core 8 with Blazor SSR

<h1>Approach</h1>
Commands are defined for the Rubik movements operations. Each command contains the Plane and Direction of rotation. The rotation is calculated using geometrical functions and exact rotation matrices.

<h1>Main Functions</h1>

<table>
    <tr>
        <td>F</td>
        <td>Front face clockwise 90°</td>
    </tr>
    <tr>
        <td>R'</td>
        <td>Right face anti-clockwise 90°</td>
    </tr>
    <tr>
        <td>U</td>
        <td>Up face clockwise 90°</td>
    </tr>
    <tr>
        <td>B'</td>
        <td>Back face anti-clockwise 90°</td>
    </tr>
    <tr>
        <td>L</td>
        <td>Left face clockwise 90°</td>
    </tr>
    <tr>
        <td>D'</td>
        <td>Down face anti-clockwise 90°</td>
    </tr>
</table>

<h1>Performance Considerations</h1>
The code is meant to be self-explanatoray and as result it does not optimize for performacne. For further developments (e.g. automation as a Rubik solver) a more optimized approach will be required. This includes replacing the current matrix calculations with explicit operations to boost performance.
