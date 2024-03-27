import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Comp04Component } from './comp-04.component';

describe('Comp04Component', () => {
  let component: Comp04Component;
  let fixture: ComponentFixture<Comp04Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Comp04Component]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(Comp04Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
