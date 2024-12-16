namespace Stack.Tests;

public class UnitTest1
{
    private Stack stack = new Stack();

    [Fact]
    public void NovaEstaVazia() {
        Assert.True(stack.EstaVazia());
    }

    [Fact]
    public void PushNaStackContinuaVazia() {
        stack.Push(0);
        Assert.False(stack.EstaVazia());
    }

    [Fact]
    public void PopNaStackVazia() {
        var exception = Assert.Throws<Exception>(() => stack.Pop());
        Assert.Equal("A pilha está vazia.", exception.Message);
    }

    [Fact]
    public void UmPushUmPopDeixaStackVazia() {
        stack.Push(99);
        int elemento = stack.Pop();
        Assert.True(stack.EstaVazia());
    }

    [Fact]
    public void UmPushUmPop() {
        stack.Push(99);
        int elemento = stack.Pop();
        Assert.Equal(99, elemento);
    }

    [Fact]
    public void DoisPushsUmPopDeixaStackVazia() {
        stack.Push(99);
        stack.Push(199);
        int elemento = stack.Pop();
        Assert.False(stack.EstaVazia());
    }

    [Fact]
    public void PushX_PushY_Retorna_YX() {
        stack.Push(99);
        stack.Push(199);

        int elemento = stack.Pop();
        Assert.Equal(199, elemento);

        elemento = stack.Pop();
        Assert.Equal(99, elemento);
    }
}