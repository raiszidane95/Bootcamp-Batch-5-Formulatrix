namespace Cars;

public class Car
{
    public IEngine engine;
    public Car(IEngine engine){
        this.engine = engine;
    }
	public void StartEngine() 
	{
		engine.EngineRun();
	}
}
