using System.Reflection.Metadata;

class BlockObj {
    int Xpos;
    int Ypos;

    bool IsStopped;

    void MoveLeft() {
        Xpos--;
    }
    void MoveRight() {
        Xpos++;
    }
    void MoveDown() {
        Ypos--;
    }
}