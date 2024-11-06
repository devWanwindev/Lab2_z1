using System;
public class logic {
    protected bool _x;
    protected bool _y;
    public logic(bool x, bool y)
    {
        this._x = x;
        this._y = y;
    }

    logic(logic copyright)
    {
        this._x = copyright._x;
        this._y = copyright._y;
    }

    public bool kon() {
        return !_x && !_y;
    }

    public override string ToString()
    {
        return $"peregruz {_x} and {_y}";
    }

}

